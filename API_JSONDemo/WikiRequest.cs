using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace API_JSONDemo
{
    public class WikiRequest
    {
        public static string jsonTemp { get; set; }
        public static List<User> userList = new List<User>();
        public static List<JToken> results = new List<JToken>();

        public static string WikiDataRequest(string x)
        {
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(x);
            http.Method = "GET";
            http.ContentType = "application/json";
            //http.Headers.Add(AUTHKEY, 234234234);
            WebResponse response = http.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                string jsonC = sr.ReadToEnd();
                jsonTemp = jsonC;
                Console.WriteLine(jsonTemp);
            }
            return jsonTemp;
        }
        public static List<User> JsonData(string z)
        {
            JObject json = JObject.Parse(z);
            List<JToken> results = json["items"].ToList();
            foreach(JToken result in results)
            {
                Console.WriteLine(result);
                User tempUser = result.ToObject<User>();
                userList.Add(tempUser);

            }
            return userList;
        }
    }
}
