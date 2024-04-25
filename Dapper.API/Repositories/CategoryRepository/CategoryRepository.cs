using Dapper.API.Dtos.CategoryDtos;
using Dapper.API.Models.DapperContext;
using Dapper;

namespace Dapper.API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDto category)
        {
            string query = "INSERT INTO Category (Name,Status) values(@name,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name",category.Name);
            parameters.Add("@status",true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "DELETE FROM Category WHERE CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId",id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategroyAsync()
        {
            string query = "SELECT * FROM Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "SELECT * FROM Category WHERE CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query,parameters);
                return value;
            }
        }

        public async void UpdateCategory(UpdateCategoryDto category)
        {
            string query = "UPDATE Category SET Name=@name,Status=@status WHERE CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", category.CategoryId);
            parameters.Add("@name", category.Name);
            parameters.Add("@status", category.Status);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
