using Abp.Web.Mvc.Views;

namespace Bcl.Web.Views
{
    public abstract class BclWebViewPageBase : BclWebViewPageBase<dynamic>
    {

    }

    public abstract class BclWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BclWebViewPageBase()
        {
            LocalizationSourceName = BclConsts.LocalizationSourceName;
        }
    }
}