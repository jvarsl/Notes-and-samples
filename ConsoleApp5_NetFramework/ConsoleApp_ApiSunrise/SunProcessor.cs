using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ApiSunrise
{
    public class SunProcessor
    {
        public SunProcessor(double latitude = 54.687157, double longitude = 25.279652)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string GetUrl() => $"https://api.sunrise-sunset.org/json?lat={Latitude}&lng={Longitude}&date=today";

        public async Task<SunModel> LoadModelAsync()
        {
            using (var responseMessage = await ApiHelper.ApiClient.GetAsync(GetUrl()))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    var sunModel = await responseMessage.Content.ReadAsAsync<SunModel>();

                    return sunModel;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
