using System.Threading.Tasks;

namespace LinkStore.Data;

public interface ILinkStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
