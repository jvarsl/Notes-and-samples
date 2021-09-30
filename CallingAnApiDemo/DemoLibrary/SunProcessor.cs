using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunInformationAsync()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=54.687157&lng=25.279652&date=today";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    var sunResultModel = await responseMessage.Content.ReadAsAsync<SunResultModel>();

                    return sunResultModel.Results;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
