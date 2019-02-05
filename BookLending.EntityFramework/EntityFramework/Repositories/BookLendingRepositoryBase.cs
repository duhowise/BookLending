using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BookLending.EntityFramework.Repositories
{
    public abstract class BookLendingRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BookLendingDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BookLendingRepositoryBase(IDbContextProvider<BookLendingDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BookLendingRepositoryBase<TEntity> : BookLendingRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BookLendingRepositoryBase(IDbContextProvider<BookLendingDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
