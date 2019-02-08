using Abp.EntityFramework;
using BookLending.Models;

namespace BookLending.EntityFramework.Repositories
{
    public class AuthorRepository:BookLendingRepositoryBase<Author,int>,IAuthorRepository
    {
        private readonly IDbContextProvider<BookLendingDbContext> _dbContextProvider;

        public AuthorRepository(IDbContextProvider<BookLendingDbContext> dbContextProvider) : base(dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }
    }
}
