using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using LinkStore.Localization;

namespace LinkStore.Web;

[Dependency(ReplaceServices = true)]
public class LinkStoreBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LinkStoreResource> _localizer;

    public LinkStoreBrandingProvider(IStringLocalizer<LinkStoreResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
