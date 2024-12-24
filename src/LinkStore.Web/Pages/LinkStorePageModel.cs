using LinkStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LinkStore.Web.Pages;

public abstract class LinkStorePageModel : AbpPageModel
{
    protected LinkStorePageModel()
    {
        LocalizationResourceType = typeof(LinkStoreResource);
    }
}
