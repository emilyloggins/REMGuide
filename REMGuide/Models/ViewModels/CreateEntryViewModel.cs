using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models.ViewModels
{
    public class AddEntryVM
    {
        public Entry Entry { get; set; }
        public List<CheckBoxListItem> Themes { get; set; }

        public AddEntryVM()
        {
            Themes = new List<CheckBoxListItem>();
        }
    }
}
