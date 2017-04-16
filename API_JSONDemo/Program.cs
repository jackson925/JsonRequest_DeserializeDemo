using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_JSONDemo
{
    class Program
    {

        List<User> user = new List<User>();

        static void Main(string[] args)
        {

            string saveLocation = @"C:\Users\User\Desktop\ExampleJSON.txt";
            string uri1 = @"https://en.wikipedia.org/api/rest_v1/page/random/title";

            string jsonContent = WikiRequest.WikiDataRequest(uri1);

            using (StreamWriter sw = new StreamWriter(saveLocation))
            {
                sw.Write(jsonContent);
            }
            IList<User> finishedList = WikiRequest.JsonData(jsonContent);
            Console.WriteLine(finishedList.Count);
            Console.WriteLine(finishedList[0].page_id);
            Console.WriteLine(finishedList[0].tid);
            Console.WriteLine(finishedList[0].title);
            Console.WriteLine(finishedList[0].user_text);
            Console.ReadLine();
            
        }

        /*static async void MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "{subscription key}");

            // Request parameters
            queryString["q"] = "cats";
            queryString["count"] = "10";
            queryString["offset"] = "0";
            queryString["mkt"] = "en-us";
            queryString["safeSearch"] = "Moderate";
            var uri = "https://api.cognitive.microsoft.com/bing/v5.0/images/search?" + queryString;

            var response = await client.GetAsync(uri);



        }
        */
     



    }
 }

