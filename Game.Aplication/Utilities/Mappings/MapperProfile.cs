using AutoMapper;
using Game.Aplication.Dto.Category;
using Game.Aplication.DTOs.Answer;
using Game.Aplication.DTOs.DifficultyLevel;
using Game.Aplication.DTOs.Question;
using Game.Domain.Entities;

namespace Game.Aplication.Utilities.Mappings
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Answer,AnswerAddRequest>().ReverseMap();
            CreateMap<Answer,AnswerUpdateRequest>().ReverseMap();
            CreateMap<Answer,AnswerTableResponse>().ReverseMap();
            CreateMap<Answer,AnswerDto>().ReverseMap();


            CreateMap<Question,QuestionAddRequest>().ReverseMap();
            CreateMap<Question, QuestionUpdateRequest>().ReverseMap();
            CreateMap<Question, QuestionTableResponse>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();


            CreateMap<DifficultyLevel,DifficultyLevelTableResponse>().ReverseMap();

            CreateMap<Category,CategoryAddRequest>().ReverseMap();
            CreateMap<Category,CategoryUpdateRequest>().ReverseMap();
            CreateMap<Category,CategoryTableResponse>().ReverseMap();

        }
    }
}
