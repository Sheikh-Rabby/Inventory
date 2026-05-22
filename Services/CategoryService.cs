using Inventory.DTO;
using Inventory.Interface;
using Inventory.Interface.ServiceInterface;
using Inventory.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Inventory.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly IBaseRepository<Category> _CategoryRepository;

        public CategoryService(IBaseRepository<Category> categoryRepository)
        {
            _CategoryRepository = categoryRepository;
        }

        public async Task AddAsync(CreateCategoryDto categoryDto)
        {
            var exists = await _CategoryRepository.GetByAsync(e => e.CategoryName == categoryDto.categoryName);
            if (exists != null)
                throw new ConflictException("Category Already Exists");

            var category = new Category
            {
                CategoryName = categoryDto.categoryName
            };

            await _CategoryRepository.AddAsync(category);

          

        }
    }
}
