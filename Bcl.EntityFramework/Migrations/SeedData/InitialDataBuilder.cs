using Bcl.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Bcl.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly BclDbContext _context;

        public InitialDataBuilder(BclDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
