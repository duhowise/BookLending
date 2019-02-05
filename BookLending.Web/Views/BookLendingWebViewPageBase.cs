using Abp.Web.Mvc.Views;

namespace BookLending.Web.Views
{
    public abstract class BookLendingWebViewPageBase : BookLendingWebViewPageBase<dynamic>
    {

    }

    public abstract class BookLendingWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BookLendingWebViewPageBase()
        {
            LocalizationSourceName = BookLendingConsts.LocalizationSourceName;
        }
    }
}