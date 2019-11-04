using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.Model
{
    public class Data
    {
        public PlatformInfo platformInfo { get; set; }
        public UserInfo userInfo { get; set; }
        public Metadata metadata { get; set; }
        public List<Segment> segments { get; set; }
        //public List<AvailableSegment> availableSegments { get; set; }
        public DateTime expiryDate { get; set; }
    }
}
