using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using BookLending.Authorization.Roles;
using BookLending.Authorization.Users;
using BookLending.Models;
using BookLending.MultiTenancy;

namespace BookLending.EntityFramework
{
    public class BookLendingDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */

        public virtual IDbSet<Author> Authors { get; set; }
        public virtual IDbSet<Book> Books { get; set; }
        public virtual IDbSet<Category> Categories { get; set; }




        public BookLendingDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BookLendingDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BookLendingDbContext since ABP automatically handles it.
         */
        public BookLendingDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BookLendingDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public BookLendingDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
