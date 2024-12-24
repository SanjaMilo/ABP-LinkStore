using Microsoft.AspNetCore.Builder;
using LinkStore;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<LinkStoreWebTestModule>();

public partial class Program
{
}
