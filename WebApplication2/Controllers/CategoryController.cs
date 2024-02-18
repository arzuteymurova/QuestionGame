using Game.Aplication.Dto.Category;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(CategoryAddRequest addRequest)
        {
            await _categoryService.AddAsync(addRequest);
            return Ok();
        }

        [HttpPost("DeleteCategoryById")]
        public async Task<IActionResult> DeleteCategoryById(int id)
        {
            await _categoryService.DeleteByIdAsync(id);
            return Ok();
        }

        [HttpPost("EditCategory")]
        public async Task<IActionResult> EditCategory(CategoryUpdateRequest request)
        {
            await _categoryService.EditAsync(request);
            return Ok();
        }

        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
          CategoryTableResponse result =  await _categoryService.GetCategoryById(id);
            return Ok(result);
        }

        [HttpGet("GetAllCategoriesAsync")]
        public async Task<IActionResult> GetAllCategories()
        {
            List<CategoryTableResponse> result = await _categoryService.GetTable();
            return Ok(result);
        }
    }
}
