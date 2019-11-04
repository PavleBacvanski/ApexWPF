using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.Model
{
    public class Segment
    {
        public string type { get; set; }
        //public Attributes attributes { get; set; }
        public Metadata2 metadata { get; set; }
        public DateTime expiryDate { get; set; }
        public Stats stats { get; set; }
    }
}
