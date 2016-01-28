using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Bcl.EntityFramework;

namespace Bcl
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BclCoreModule))]
    public class BclDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
