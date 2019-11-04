using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.Model
{
    public class UserInfo
    {
        public bool isPremium { get; set; }
        public bool isVerified { get; set; }
        public bool isInfluencer { get; set; }
        public string countryCode { get; set; }
        public object customAvatarUrl { get; set; }
        public object socialAccounts { get; set; }
    }
}
