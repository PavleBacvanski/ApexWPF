using ApexWPF.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ApexWPF.API
{
    public class PlayerApi : Api
    {
        public PlayerApi(string platform) : base(platform)
        {
        }

        public RootObject GetPlayerByName(string platform, string platformUserIdentifier)
        {
            string path = "standard/profile/" + platform + "/" + platformUserIdentifier;
            
            var response = GetHttp(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<RootObject>(content);
                //JavaScriptSerializer jsonSerializier = new JavaScriptSerializer();
                //RootObject platformInfo = jsonSerializier.Deserialize<RootObject>(content);

                //return platformInfo;
            }
            else
            {
                return null;
            }

        }
    }
}
