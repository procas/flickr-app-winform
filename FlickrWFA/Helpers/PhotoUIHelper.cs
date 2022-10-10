using FlickrWFA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json.Linq;

namespace FlickrWFA.Helpers
{
    public class PhotoUIHelper : IPhotoUIHelper
    {
        private readonly RestClientProvider restClientProvider;
        public PhotoUIHelper()
        {
            this.restClientProvider = new RestClientProvider();
        }

        public string getHtml(string tag)
        {
            HttpContent html;
            try
            {
                html = restClientProvider.GetHtml(tag);
            }
            catch (Exception e)
            {
                return e.StackTrace;
            }
            string res = html.ReadAsStringAsync().Result;
            //List<string> list = res.Split(',').ToList();
            return res;
        }
    }
}
