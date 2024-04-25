using Dapper.API.Dtos.CategoryDtos;
using Dapper.API.Repositories.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategroyAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _categoryRepository.GetCategory(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto category)
        {
            _categoryRepository.CreateCategory(category);
            return Ok("Kategori başarıyla eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori başarıyla silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto category)
        {
            _categoryRepository.UpdateCategory(category);
            return Ok("Kategori başarıyla güncellendi.");
        }
    }
}
