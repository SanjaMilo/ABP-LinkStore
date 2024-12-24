using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LinkStore.LinkSets
{
    public class OriginalUrlDto : AuditedEntityDto<Guid>
    {
        public required string OriginalUrl { get; set; }
    }
}
