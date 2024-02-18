using Game.Aplication.DTOs.Question;
using Game.Aplication.Services.Abstract;
using Game.Aplication.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gamesService;

        public GameController(IGameService gamesService)
        {
            _gamesService = gamesService;
        }

        [HttpGet("GetAllCategoriesAsync")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _gamesService.GetAllCategoriesAsync();
            return Ok(result);

        }

        [HttpGet("GetUniqueQuestionsForGamerAsync")]
        public async Task<IActionResult> GetUniqueQuestionsForGamerAsync(int gamerId, int categoryId, int difficultyLevelId)
        {
            var result = await _gamesService.GetUniqueQuestionsForGamerAsync(gamerId, categoryId, difficultyLevelId);
            return Ok(result);
        }

        [HttpGet("CheckAnswerAsync")]
        public async Task<IActionResult> CheckAnswer(int answerId)
        {
            var result = await _gamesService.CheckAnswerAsync(answerId);
            return Ok(result);
        }

        [HttpGet("GetDifficultyLevels")]
        public async Task<IActionResult> GetDifficultyLevels(int categoryId)
        {
            var result = await _gamesService.GetAllDifficultyLevelsAsync(categoryId);
            return Ok(result);
        }

        [HttpGet("ResetQuestionsForPlayerAsync")]
        public async Task<IActionResult> ResetQuestionsForPlayerAsync(int gamerId)
        {
            await _gamesService.ResetQuestionsForPlayerAsync(gamerId);
            return Ok();
        }

       
    }
}
