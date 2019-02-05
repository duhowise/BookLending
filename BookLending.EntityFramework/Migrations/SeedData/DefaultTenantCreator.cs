using System.Linq;
using BookLending.EntityFramework;
using BookLending.MultiTenancy;

namespace BookLending.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly BookLendingDbContext _context;

        public DefaultTenantCreator(BookLendingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
