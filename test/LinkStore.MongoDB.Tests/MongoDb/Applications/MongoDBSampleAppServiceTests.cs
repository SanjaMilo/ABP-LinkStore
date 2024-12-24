using LinkStore.MongoDB;
using LinkStore.Samples;
using Xunit;

namespace LinkStore.MongoDb.Applications;

[Collection(LinkStoreTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<LinkStoreMongoDbTestModule>
{

}
