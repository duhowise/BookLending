using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace BookLending.Models
{
    public interface ICategoryManger : IDomainService
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetCategoryById(int id);
        Task<Category> Create(Category entity);
        Task Update(Category entity);
        Task Delete(int id);
    }
}