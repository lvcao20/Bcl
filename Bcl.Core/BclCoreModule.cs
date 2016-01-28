using System.Reflection;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Configuration;
using Bcl.Authorization;
using Bcl.Authorization.Roles;

namespace Bcl
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class BclCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = false;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    BclConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "Bcl.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<BclAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
