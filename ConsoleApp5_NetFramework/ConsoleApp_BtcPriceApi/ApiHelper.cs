using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BtcPriceApi
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; private set; }

        public static void InitializeApiClient()
        {
            ApiClient = new HttpClient();
          //  ApiClient.DefaultRequestHeaders.Accept.Clear();
          //  ApiClient.DefaultRequestHeaders.Accept.Add(
           //     new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
        }

    }
}
