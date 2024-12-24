using LinkStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LinkStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LinkStoreController : AbpControllerBase
{
    protected LinkStoreController()
    {
        LocalizationResource = typeof(LinkStoreResource);
    }
}
