using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using CacheManager.Core;
using CacheManager.SystemRuntimeCaching;
using CacheManager.Redis;

namespace Bcl
{
    [DependsOn(typeof(BclCoreModule), typeof(AbpAutoMapperModule))]
    public class BclApplicationModule : AbpModule
    {
        
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
