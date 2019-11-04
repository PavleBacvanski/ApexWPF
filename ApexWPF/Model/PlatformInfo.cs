using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.Model
{
    public class PlatformInfo
    {
        public string platformSlug { get; set; }
        public string platformUserId { get; set; }
        public string platformUserHandle { get; set; }
        public string platformUserIdentifier { get; set; }
        public string avatarUrl { get; set; }
        public object additionalParameters { get; set; }
    }
}
