using Volo.Abp.Modularity;

namespace LinkStore;

[DependsOn(
    typeof(LinkStoreApplicationModule),
    typeof(LinkStoreDomainTestModule)
)]
public class LinkStoreApplicationTestModule : AbpModule
{

}
