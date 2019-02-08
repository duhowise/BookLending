using Abp.EntityFramework;
using BookLending.Models;

namespace BookLending.EntityFramework.Repositories
{
    public class BookRepository : BookLendingRepositoryBase<Book,int>
    {
        public BookRepository(IDbContextProvider<BookLendingDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }

    public class CategoryRepository : BookLendingRepositoryBase<Category,int>
    {
        public CategoryRepository(IDbContextProvider<BookLendingDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}