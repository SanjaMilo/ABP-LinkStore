using LinkStore.Localization;
using Volo.Abp.Application.Services;

namespace LinkStore;

/* Inherit your application services from this class.
 */
public abstract class LinkStoreAppService : ApplicationService
{
    protected LinkStoreAppService()
    {
        LocalizationResource = typeof(LinkStoreResource);
    }
}
