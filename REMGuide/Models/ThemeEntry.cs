using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models
{
    public class ThemeEntry
    {
        public int Id { get; set; }
        public int EntryId { get; set; }
        public int ThemeId { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
