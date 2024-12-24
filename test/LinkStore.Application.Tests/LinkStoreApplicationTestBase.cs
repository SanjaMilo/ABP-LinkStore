using Volo.Abp.Modularity;

namespace LinkStore;

public abstract class LinkStoreApplicationTestBase<TStartupModule> : LinkStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
