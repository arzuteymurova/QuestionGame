using AutoMapper;
using Game.Aplication.DTOs.Answer;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;

namespace Game.Aplication.Services.Concrete
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;
        private readonly IMapper _mapper;
        public AnswerService(IAnswerRepository repository, IMapper mapper)
        {
            _answerRepository = repository;
            _mapper = mapper;
        }
        public async Task AddAsync(AnswerAddRequest answerAddRequest)
        {
            Answer answer = _mapper.Map<Answer>(answerAddRequest);
            await _answerRepository.CreateAsync(answer);
        }
        public async Task EditAsync(AnswerUpdateRequest answerUpdateRequest)
        {
            Answer answer = _mapper.Map<Answer>(answerUpdateRequest);
            await _answerRepository.UpdateAsync(answer);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Answer answer = await _answerRepository.FindByIdAsync(id);
            await _answerRepository.DeActivate(answer);
        }

        public async Task<AnswerTableResponse> GetAnswerById(int id)
        {
            Answer answer = await _answerRepository.FindByIdAsync(id);
            AnswerTableResponse result = _mapper.Map<AnswerTableResponse>(answer);
            
            return result;

        }

        public async Task<List<AnswerTableResponse>> GetTable()
        {
            List<Answer> answers = await _answerRepository.FindAllActiveAsync();
            List<AnswerTableResponse> result=_mapper.Map<List<AnswerTableResponse>>(answers);

            return result;
        }
    }
}
