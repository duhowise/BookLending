using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace BookLending.Models
{
    public class CategoryManager:DomainService,ICategoryManger
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryManager(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            return await  _categoryRepository.GetAllListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category= await _categoryRepository.GetAsync(id);
            if (category == null) throw new UserFriendlyException("Category ot found");
            return category;
        }

        public async Task<Category> Create(Category entity)
        {
            var category = await _categoryRepository.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (category == null) return await _categoryRepository.InsertAsync(entity);
            throw new UserFriendlyException("Category already exists");
           
        }

        public async Task Update(Category entity)
        {
            var category = await _categoryRepository.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (category == null) throw new UserFriendlyException("Category not found");
            await _categoryRepository.UpdateAsync(entity);
        }

        public async Task Delete(int id)
        {
            var category = await _categoryRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null) throw new UserFriendlyException("Category not found");
            await _categoryRepository.DeleteAsync(category);
        }
    }
}