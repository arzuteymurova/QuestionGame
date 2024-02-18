using Game.Aplication.DTOs.Question;
using Game.Aplication.Services.Abstract;
using Game.Aplication.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService service)
        {
            _questionService = service;
        }

        [HttpPost("AddQuestion")]
        public async Task<IActionResult> AddQuestion(QuestionAddRequest req)
        { 
            await _questionService.AddAsync(req);
            return Ok();
        }

        [HttpPost("DeleteQuestionById")]
        public async Task<IActionResult> DeleteQuestionById(int id)
        {
            await _questionService.DeleteByIdAsync(id);
            return Ok();
        }

        [HttpPost("UpdateQuestion")]
        public async Task<IActionResult> UpdateQuestion(QuestionUpdateRequest req)
        { 
           await _questionService.EditAsync(req);
            return Ok();
        }

        [HttpGet("GetQuestionById")]
        public async Task<IActionResult> GetQuestionById(int id)
        {
            var result = await _questionService.GetQuestionById(id);
            return Ok(result);
        }

        [HttpGet("GetAllQuestions")]
        public async Task<IActionResult> GetAllQuestions()
        {
            var result=  await _questionService.GetTable();
            return Ok(result);
        }
    } 
}
