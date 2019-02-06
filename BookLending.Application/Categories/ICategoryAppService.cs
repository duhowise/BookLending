using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace BookLending.Categories
{
    public interface ICategoryAppService:IApplicationService
    {
        Task<IEnumerable<GetCategoryOutput>> GetAll();
        Task<GetCategoryOutput> GetCategoryById(GetCategoryInput id);
        Task Create(CreateCategoryInput entity);
        Task Update(UpdateCategoryInput entity);
        Task Delete(DeleteCategoryInput id);
    }
}