using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace BookLending.Models
{
    public interface IAuthorManger : IDomainService
    {
        Task<IEnumerable<Author>> GetAll();
        Task<Author> GetAuthorById(int id);
        Task<Author> Create(Author entity);
        Task Update(Author entity);
        Task Delete(int id);
    }
}
