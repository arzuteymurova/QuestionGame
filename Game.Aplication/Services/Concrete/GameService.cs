using AutoMapper;
using Game.Aplication.Dto.Category;
using Game.Aplication.DTOs.Answer;
using Game.Aplication.DTOs.DifficultyLevel;
using Game.Aplication.DTOs.Question;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;

namespace Game.Aplication.Services.Concrete
{
    public class GameService : IGameService
    {
        private readonly IDifficultyLevelRepository _difficultyLevelRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IGamerRepository _gamerRepository;
        private readonly IMapper _mapper;
        public GameService(ICategoryRepository categoryRepository, IAnswerRepository answerRepository,
            IQuestionRepository questionRepository, IDifficultyLevelRepository difficultyLevelRepository,
            IMapper mapper, IGamerRepository gamerRepository)
        {
            _categoryRepository = categoryRepository;
            _answerRepository = answerRepository;
            _questionRepository = questionRepository;
            _difficultyLevelRepository = difficultyLevelRepository;
            _gamerRepository = gamerRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryTableResponse>> GetAllCategoriesAsync()
        {
            List<Category> categories = await _categoryRepository.FindAllActiveAsync();
            List<CategoryTableResponse> result = _mapper.Map<List<CategoryTableResponse>>(categories);

            return result;
        }
        public async Task<List<DifficultyLevelTableResponse>> GetAllDifficultyLevelsAsync(int CategoryId)
        {
            List<DifficultyLevel> levels = await _difficultyLevelRepository.FindAllActiveAsync();
            List<DifficultyLevelTableResponse> result = _mapper.Map<List<DifficultyLevelTableResponse>>(levels);

            return result;

        }
        public async Task<QuestionDto> GetUniqueQuestionsForGamerAsync(int gamerId, int categoryId, int difficultyLevelId)
        {
            List<Category> categories = await _categoryRepository.FindAllActiveAsync();
            List<Question> questions = await _questionRepository.FindAllActiveAsync();
            List<Answer> answers = await _answerRepository.FindAllActiveAsync();
            Gamer gamer = await _gamerRepository.FindByIdAsync(gamerId);

            var result = from category in categories
                         join question in questions
                         on category.Id equals question.CategoryId
                         join answer in answers
                         on question.Id equals answer.QuestionId
                         where question.DifficultLevelId == difficultyLevelId && question.CategoryId == categoryId
                         select new QuestionDto
                         {
                             Id = question.Id,
                             Content = question.Content,
                             Answers = question.Answers.Select(a => new AnswerDto { Id = a.Id, Value = a.Value }).ToList()

                         };

            gamer.AskedQuestions ??= [];

            var unansweredQuestions = result.Where(q => !gamer.AskedQuestions.Contains(q.Id)).ToList();
            if (unansweredQuestions.Count == 0)
                return null;

            var randomQuestion = unansweredQuestions[new Random().Next(0, unansweredQuestions.Count)];
            gamer.AskedQuestions.Add(randomQuestion.Id);
            await _gamerRepository.UpdateAsync(gamer);

            return randomQuestion;

        }
        public async Task<string> CheckAnswerAsync(int answerId)
        {
            Answer answer = await _answerRepository.FindByConditionFirstOrDefaultAsync(a => a.Id == answerId);
            bool checkAnswer = answer.IsTrue == IsTrue.True;
            if (!checkAnswer)
            {
                return "Answer is wrong! Gamer is ended!";
            }
            else
            {
                return "Answer is correct! Go to the next question!";
            }
        }
        public async Task ResetQuestionsForPlayerAsync(int gamerId)
        {
            Gamer gamer = await _gamerRepository.FindByIdAsync(gamerId);
            gamer.AskedQuestions.Clear();
            await _gamerRepository.UpdateAsync(gamer);
        }
        

    }
}
