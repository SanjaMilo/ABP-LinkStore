using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace LinkStore.MongoDB;

[DependsOn(
    typeof(LinkStoreApplicationTestModule),
    typeof(LinkStoreMongoDbModule)
)]
public class LinkStoreMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = LinkStoreMongoDbFixture.GetRandomConnectionString();
        });
    }
}
