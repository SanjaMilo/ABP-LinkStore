using Volo.Abp.Modularity;

namespace LinkStore;

/* Inherit from this class for your domain layer tests. */
public abstract class LinkStoreDomainTestBase<TStartupModule> : LinkStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
