using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LinkStore.LinkSets
{
    public class ShortUrlIdDto : AuditedEntityDto<Guid>
    {
        public required string ShortUrlId { get; set; }
    }
}
