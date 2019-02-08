using Abp.Domain.Repositories;
using BookLending.Models;

namespace BookLending.EntityFramework.Repositories
{
    public interface IAuthorRepository:IRepository<Author,int>
    {
    }
}
