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
            restClientProvider = new RestClientProvider();
        }
        public List<string> getUrlList(string tag)
        {
            HttpContent urls;
            try
            {
                urls = restClientProvider.GetUrls(tag);
            }
            catch(Exception)
            {
                return new List<string>();
            }
            string res = urls.ReadAsStringAsync().Result;
            List<string> list = res.Split(',').ToList();
            return list;
        }

        List<string> IPhotoUIHelper.getUrlList()
        {
            throw new NotImplementedException();
        }
    }
}
