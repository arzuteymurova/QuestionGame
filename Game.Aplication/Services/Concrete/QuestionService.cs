using AutoMapper;
using Game.Aplication.Dto.Category;
using Game.Aplication.DTOs.Question;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Concrete
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository respository, IMapper mapper)
        {
            _questionRepository = respository;
            _mapper = mapper;
        }

        public async Task AddAsync(QuestionAddRequest questionAddRequest)
        {
            Question question = _mapper.Map<Question>(questionAddRequest);
            await _questionRepository.CreateAsync(question);

        }

        public async Task DeleteByIdAsync(int id)
        {
            Question question = await _questionRepository.FindByIdAsync(id);
            await _questionRepository.DeActivate(question);
        }

        public async Task EditAsync(QuestionUpdateRequest questionUpdateRequest)
        {
            Question question = _mapper.Map<Question>(questionUpdateRequest);
            await _questionRepository.UpdateAsync(question);
        }

        public async Task<QuestionTableResponse> GetQuestionById(int id)
        {
            Question question = await _questionRepository.FindByIdAsync(id);
            QuestionTableResponse result=_mapper.Map<QuestionTableResponse>(question);

            return result;
        }

        public async Task<List<QuestionTableResponse>> GetTable()
        {           
            List<Question> questions = await _questionRepository.FindAllActiveAsync();
            List<QuestionTableResponse> result = _mapper.Map<List<QuestionTableResponse>>(questions);

            return result;
        }
    }
}
