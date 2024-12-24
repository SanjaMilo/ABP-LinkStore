using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LinkStore.LinkSets
{
    public interface ILinkSetAppService : IApplicationService
    {
        // Task<TResult> is the return type for an async method that returns a value.
        Task<List<LinkSetDto>> GetListAsync(); // GET lista na site link-setovi (GET method)
        Task<LinkSetDto> CreateAsync(CreateLinkSetDto longUrl); // POST kreiraj nov link-set (POST method)
        Task<OriginalUrlDto> InsertAsync(ShortUrlIdDto shortId); // POST spored id-to na short-link-ot, najdi go link-setot od koj original-url ke go retun-eme (POST method, sends the id)
    }
}
