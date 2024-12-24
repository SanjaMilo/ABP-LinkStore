using LinkStore.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LinkStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LinkStoreMongoDbModule),
    typeof(LinkStoreApplicationContractsModule)
)]
public class LinkStoreDbMigratorModule : AbpModule
{
}
