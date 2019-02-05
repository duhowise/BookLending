using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace BookLending.Models
{
    public interface IBookManger : IDomainService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> GetBookById(int id);
        Task<Book> Create(Book entity);
        Task Update(Book entity);
        Task Delete(int id);
    }
}