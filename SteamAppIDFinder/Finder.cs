using Newtonsoft.Json;
using RestSharp;
using Microsoft.CSharp;
using System.Collections.Generic;

namespace SteamAppIDFinder
{
    public class Finder
    {
      
        public static dynamic getResponse()
        {
            var client = new RestClient("https://api.steampowered.com/ISteamApps/GetAppList/v2/");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            IRestResponse response = client.Execute(request);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            return jsonResponse;
        }

        public static List<string[]> result(dynamic response, string search)
        {
            List<string[]> arrayList = new List<string[]>();
            foreach (dynamic res in response["applist"]["apps"])
            {
            
              
                string name = res["name"];
                if (name.Contains(search))
                {


                    string[] item = { res["name"], res["appid"] };
                    arrayList.Add(item);
                    

                }
            }

            return arrayList;
        }

    }
}
