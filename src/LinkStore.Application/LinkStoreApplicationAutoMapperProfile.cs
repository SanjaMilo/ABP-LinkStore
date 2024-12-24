using AutoMapper;
using LinkStore.LinkSets; // ova

namespace LinkStore;

public class LinkStoreApplicationAutoMapperProfile : Profile
{
    public LinkStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
        * Alternatively, you can split your mapping configurations
        * into multiple profile classes for a better organization. */

        CreateMap<LinkSet, LinkSetDto>(); // ova mapping (entity -> DTO)

        CreateMap<CreateLinkSetDto, LinkSet>();  // ova mapping (DTO -> entity)
    }
}
