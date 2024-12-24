using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // ova za [Required]
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkStore.LinkSets
{
    public class CreateLinkSetDto
    {
        [Required]
        public required string OriginalUrl { get; set; }

        //[Required]
        //public required string ShortUrl { get; set; }

        //[Required]
        //public required string ShortUrlId { get; set; }
    }
}
