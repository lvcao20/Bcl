using System.Data.Entity.Migrations;
using Bcl.Migrations.SeedData;

namespace Bcl.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Bcl.EntityFramework.BclDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Bcl";
        }

        protected override void Seed(Bcl.EntityFramework.BclDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
