using Game.Aplication.DTOs.Answer;
using Game.Aplication.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        public AnswerController(IAnswerService service)
        {
            _answerService = service;
        }

        [HttpPost("AddAnswer")]
        public async Task<IActionResult> AddAnswer(AnswerAddRequest req)
        {
            await _answerService.AddAsync(req);
            return Ok();
        }

        [HttpPost("UpdateAnswer")]
        public async Task<IActionResult> UpdateAnswer(AnswerUpdateRequest req)
        {
            await _answerService.EditAsync(req);
            return Ok();
        }

        [HttpPost("DeleteAnswerById")]
        public async Task<IActionResult> DeleteAnswerById(int id)
        {
            await _answerService.DeleteByIdAsync(id);
            return Ok();
        }

        [HttpGet("GetAnswerById")]
        public async Task<IActionResult> GetAnswerById(int id)
        {
            var result = await _answerService.GetAnswerById(id);
            return Ok(result);
        }

        [HttpGet("GetAllAnswers")]
        public async Task<IActionResult> getAllAnswers()
        {
            var result = await _answerService.GetTable();
            return Ok(result);
        }
    }
}
