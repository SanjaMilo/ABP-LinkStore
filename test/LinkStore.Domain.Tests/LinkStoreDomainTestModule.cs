using Volo.Abp.Modularity;

namespace LinkStore;

[DependsOn(
    typeof(LinkStoreDomainModule),
    typeof(LinkStoreTestBaseModule)
)]
public class LinkStoreDomainTestModule : AbpModule
{

}
