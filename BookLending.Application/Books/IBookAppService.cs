using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace BookLending.Books
{
    public interface IBookAppService:IApplicationService
    {
        Task<IEnumerable<GetBookOutput>> GetAll();
        Task<GetBookOutput> GetBookById(GetBookInput id);
        Task Create(CreateBookInput entity);
        Task Update(UpdateBookInput entity);
        Task Delete(DeleteBookInput id);
    }
}