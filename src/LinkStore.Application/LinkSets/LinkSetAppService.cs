using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos; // ova
using Volo.Abp.Domain.Repositories; // ova
using LinkStore.Utils; // ova
using Volo.Abp; // ova


namespace LinkStore.LinkSets
{
    // Application Service Implementation
    public class LinkSetAppService : ApplicationService, ILinkSetAppService
    {
        //public LinkSetAppService(IRepository<LinkSet, Guid> repository)
        //    : base(repository)
        //{

        //} // ova e od templejtot


        // OVA:

        private readonly IRepository<LinkSet, Guid> _linkSetRepository; // ova _linkSetRepository e field (variable)

        public LinkSetAppService(IRepository<LinkSet, Guid> linkSetRepository)
        {
            _linkSetRepository = linkSetRepository;
        }

        // TODO: Implement the interface ILinkSetAppService methods here...

        // 1. Implementing the Task<List<LinkSetDto>> GetListAsync() method:
        public async Task<List<LinkSetDto>> GetListAsync()
        {
            var linkSetsList = await _linkSetRepository.GetListAsync();

            return ObjectMapper.Map<List<LinkSet>, List<LinkSetDto>>(linkSetsList);
        }

        // 2. Implementing the Task<LinkSetDto> CreateAsync(string longUrl) method:
        // Use the "Utils" methods here:
        public async Task<LinkSetDto> CreateAsync(CreateLinkSetDto longUrl)
        {
            string baseUrl = "http://localhost:44303";

            string shortUrlId = HelperText.GenerateUniqueShortId();

            bool isValidUrl = HelperText.IsValidUrl(longUrl.OriginalUrl);

            if (!isValidUrl) 
            {
                throw new UserFriendlyException("Invalid Original URL");
            }

            string shortUrl = $"{baseUrl}/{shortUrlId}";

            // create an instance of the LinkSet entity:
            var linkSet = new LinkSet
            {
                OriginalUrl = longUrl.OriginalUrl,
                ShortUrl = shortUrl,
                ShortUrlId = shortUrlId
            };

            await _linkSetRepository.InsertAsync(linkSet);

            return ObjectMapper.Map<LinkSet, LinkSetDto>(linkSet);
        }

        // 3. Implementing the ITask<string> InsertAsync(string shortId) method:
        // Spored Id-ot (od url-ot) treba da go najdeme link-setot od koj ke treba da go
        // vratime originalniot url na koj userot ke bide redirektiran (otvoren nov browser window)
        public async Task<OriginalUrlDto> InsertAsync(ShortUrlIdDto shortId)
        {
            var link = await _linkSetRepository.FirstOrDefaultAsync(link => link.ShortUrlId == shortId.ShortUrlId);

            if (link != null)
            {
                return new OriginalUrlDto 
                { 
                    OriginalUrl = link.OriginalUrl 
                };
            }
            else
            {
                throw new UserFriendlyException("Cannot find this URL!");
            }
        }

    }
}
