using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models
{
    public class SleepCycle
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime Date { get; set; }
        public int Disruptions { get; set; }
    }
}
