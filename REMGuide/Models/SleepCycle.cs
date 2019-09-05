using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REMGuide.Models
{
    public class SleepCycle
    {
        public int MyProperty { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Disruptions { get; set; }
    }
}
