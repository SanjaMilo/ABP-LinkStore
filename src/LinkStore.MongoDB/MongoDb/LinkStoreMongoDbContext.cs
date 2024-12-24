using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using MongoDB.Driver;
using LinkStore.LinkSets; // ova

namespace LinkStore.MongoDB;

[ConnectionStringName("Default")]
public class LinkStoreMongoDbContext : AbpMongoDbContext
{

    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public IMongoCollection<LinkSet> LinkSets => Collection<LinkSet>();  // ova

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
