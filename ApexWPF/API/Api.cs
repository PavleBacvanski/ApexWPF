using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.API
{
    public class Api
    {
        //private string Key { get; set; }
        private string Platform { get; set; }

        public Api(string platform)
        {
            Platform = platform;
            //Key = GetKey("API/Key.txt");
        }

        //You need your own API key
        protected HttpResponseMessage GetHttp(string URL)
        {
            using(HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("TRN-Api-Key", "xxxxx-Your Key-xxxxx");
                var result = client.GetAsync(URL);
                result.Wait();
                
                return result.Result;
            }
        }

        protected string GetURI(string path)
        {
            return "https://public-api.tracker.gg/v2/apex/" + path;
        } 

        //public string GetKey(string path)
        //{
        //    StreamReader reader = new StreamReader(path);
        //    return reader.ReadToEnd();
        //}
    }
}
