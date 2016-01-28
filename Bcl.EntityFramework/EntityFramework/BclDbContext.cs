using System.Data.Common;
using Abp.Zero.EntityFramework;
using Bcl.Authorization.Roles;
using Bcl.MultiTenancy;
using Bcl.Users;

namespace Bcl.EntityFramework
{
    public class BclDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public BclDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BclDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BclDbContext since ABP automatically handles it.
         */
        public BclDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BclDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
