using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using BookLending.Models;

namespace BookLending.Categories
{
    public class CategoryAppService:ApplicationService,ICategoryAppService
    {
        private readonly ICategoryManger _categoryManger;

        public CategoryAppService(ICategoryManger categoryManger)
        {
            _categoryManger = categoryManger;
        }
        public async Task<IEnumerable<GetCategoryOutput>> GetAll()
        {
            return Mapper.Map<ICollection<GetCategoryOutput>>(await _categoryManger.GetAll());
        }

        public async Task<GetCategoryOutput> GetCategoryById(GetCategoryInput categoryInput)
        {
            return Mapper.Map<GetCategoryOutput>(await _categoryManger.GetCategoryById(categoryInput.Id));

        }

        public async Task Create(CreateCategoryInput entity)
        {
            var category = Mapper.Map<CreateCategoryInput, Category>(entity);
            await _categoryManger.Create(category);
        }

        public async Task Update(UpdateCategoryInput entity)
        {
            var category = Mapper.Map<UpdateCategoryInput, Category>(entity);
            await _categoryManger.Update(category);

        }

        public async Task Delete(DeleteCategoryInput deleteCategory)
        {
            await _categoryManger.Delete(deleteCategory.Id);
        }
    }
}
