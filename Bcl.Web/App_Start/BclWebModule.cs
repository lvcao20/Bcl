using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Zero.Configuration;
using Abp.Modules;
using Abp.Web.Mvc;
using Bcl.Api;

namespace Bcl.Web
{
    [DependsOn(
        typeof(BclDataModule), 
        typeof(BclApplicationModule), 
        typeof(BclWebApiModule),
        typeof(AbpWebMvcModule))]
    public class BclWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<BclNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
