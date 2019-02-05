using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BookLending.EntityFramework;

namespace BookLending.Migrator
{
    [DependsOn(typeof(BookLendingDataModule))]
    public class BookLendingMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BookLendingDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}