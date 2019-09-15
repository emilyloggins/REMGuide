using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models.ViewModels
{
    public class HomePageViewModel
    {
        public ICollection<Theme> TopThemes { get; set; }
    }
}
