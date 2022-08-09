using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlickrWFA.Service
{
    public interface IRestClientProvider
    {
        public HttpContent GetHtml(string tag);
    }
}
