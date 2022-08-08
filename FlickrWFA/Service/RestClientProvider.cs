using FlickrWFA.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace FlickrWFA.Service
{
    public class RestClientProvider
    {
        private readonly HttpClient client;
        public RestClientProvider()
        {
            client = new HttpClient();
        }

        public HttpContent GetHtml(string tag)
        {
            string url = ConfigurationManager.AppSettings["getHtml"] + tag;
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var restResponse = client.SendAsync(request).Result;
            if (!restResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("Unable to fetch html");
                throw new Exception("Unable to fetch html");
            }
            return restResponse.Content;
        }
    }
}
