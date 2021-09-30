using ConsoleApp_BtcPriceApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BtcPriceApi.Processors
{
    public static class BitcoinPriceProcessor
    {
        public static async Task<BitcoinPriceModel> GetBitcoinPriceModelAsync()
        {
            var url = $"https://api.coindesk.com/v1/bpi/currentprice.json";
            using (var httpResponse = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (httpResponse.IsSuccessStatusCode)
                {
                    //var model = await httpResponse.Content.ReadAsAsync<BitcoinPriceModel>(); 
                    // app/javascript is not accepted header by this class

                    var jsonString = await httpResponse.Content.ReadAsStringAsync();
                    var bpiModel = JsonConvert.DeserializeObject<BitcoinPriceModel>(jsonString);
                    return bpiModel;
                }
                else
                {
                    throw new Exception(httpResponse.ReasonPhrase);
                }
            }
        }
    }
}
