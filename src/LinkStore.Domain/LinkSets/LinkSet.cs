using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace LinkStore.LinkSets
{
    public class LinkSet : AuditedAggregateRoot<Guid>
    {
        public required string OriginalUrl { get; set; }

        public required string ShortUrl { get; set; }

        public required string ShortUrlId { get; set; }
    }
}
