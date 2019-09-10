using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }        
        //public List<Theme> Themes { get; set; }
        public List<CheckBoxListItem> Themes { get; set; }
        public List<ThemeEntry> ThemeEntries { get; set; }

    }
}
