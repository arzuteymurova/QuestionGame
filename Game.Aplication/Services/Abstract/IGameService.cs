using Game.Aplication.Dto.Category;
using Game.Aplication.DTOs.DifficultyLevel;
using Game.Aplication.DTOs.Question;
using Game.Domain.Entities;

namespace Game.Aplication.Services.Abstract
{
    public interface IGameService
    {
        Task<List<CategoryTableResponse>> GetAllCategoriesAsync();
        Task<List<DifficultyLevelTableResponse>> GetAllDifficultyLevelsAsync(int categoryId);
        Task<QuestionDto> GetUniqueQuestionsForGamerAsync(int gamerId, int categoryId, int difficultyLevelId);
        Task<string> CheckAnswerAsync(int answerId);
        Task ResetQuestionsForPlayerAsync(int gamerId);


    }
}
