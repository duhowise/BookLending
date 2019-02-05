using BookLending.EntityFramework;
using EntityFramework.DynamicFilters;

namespace BookLending.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BookLendingDbContext _context;

        public InitialHostDbBuilder(BookLendingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
