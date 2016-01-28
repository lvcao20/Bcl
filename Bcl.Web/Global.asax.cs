using System;
using Abp.Dependency;
using Abp.Web;
using Castle.Facilities.Logging;
using CacheManager.Core;

namespace Bcl.Web
{
    public class MvcApplication : AbpWebApplication
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseNLog().WithConfig("nlog.config")
                //f.UseLog4Net().WithConfig("log4net.config")
                );
            base.Application_Start(sender, e);
        }
    }
}
