using FlickrWFA.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlickrWFA.Service
{
    public class RestClientProvider
    {
        private readonly HttpClient client;
        public RestClientProvider()
        {
            client = new HttpClient();
        }
        public HttpContent GetUrls(string tag)
        {
            string url = "https://flickr-app-08.herokuapp.com/GetPhoto/getUrls/" + tag;
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var restResponse = client.SendAsync(request).Result;
            if (!restResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("Unable to fetch images");
                throw new Exception("Unable to fetch images");
            }
            return restResponse.Content;
        }
    }
}
