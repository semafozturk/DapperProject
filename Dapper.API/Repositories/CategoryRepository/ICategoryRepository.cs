using Dapper.API.Dtos.CategoryDtos;

namespace Dapper.API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategroyAsync();
        void CreateCategory(CreateCategoryDto category);
        void UpdateCategory(UpdateCategoryDto category);
        void DeleteCategory(int id);
        Task<GetByIdCategoryDto> GetCategory(int id);

    }
}
