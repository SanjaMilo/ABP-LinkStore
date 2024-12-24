using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LinkStore.Pages;

[Collection(LinkStoreTestConsts.CollectionDefinitionName)]
public class Index_Tests : LinkStoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
