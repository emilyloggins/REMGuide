using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models.ViewModels
{
    public class CreateEntryViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }
        public Student Student { get; set; }
    }
}
