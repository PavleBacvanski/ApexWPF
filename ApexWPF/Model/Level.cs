using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.Model
{
    public class Level
    {
        //public int rank { get; set; }
        public double percentile { get; set; }
        public string displayName { get; set; }
        public string displayCategory { get; set; }
        public object category { get; set; }
        //public Metadata3 metadata { get; set; }
        public float value { get; set; }
        public string displayValue { get; set; }
        public string displayType { get; set; }

    }
}
