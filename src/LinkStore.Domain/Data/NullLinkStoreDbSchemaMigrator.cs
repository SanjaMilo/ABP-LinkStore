using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LinkStore.Data;

/* This is used if database provider does't define
 * ILinkStoreDbSchemaMigrator implementation.
 */
public class NullLinkStoreDbSchemaMigrator : ILinkStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
