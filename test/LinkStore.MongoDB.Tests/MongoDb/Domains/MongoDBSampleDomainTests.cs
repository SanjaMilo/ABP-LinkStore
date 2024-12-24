using LinkStore.Samples;
using Xunit;

namespace LinkStore.MongoDB.Domains;

[Collection(LinkStoreTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<LinkStoreMongoDbTestModule>
{

}
