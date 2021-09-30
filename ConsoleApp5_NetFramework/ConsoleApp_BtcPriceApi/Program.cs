using ConsoleApp_BtcPriceApi.Processors;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BtcPriceApi
{
    public class Joke
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string ApplicationUser { get; set; }
    }


    class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper.InitializeApiClient();
            var uri = new Uri("https://localhost:44301/api/jokes");
            var model = await BitcoinPriceProcessor.GetBitcoinPriceModelAsync();

            await GetJoke(uri);

            Console.WriteLine(JsonConvert.SerializeObject(model));
            Console.ReadKey();
        }

        public static async Task PostJoke(Uri uri)
        {
            var joke = new Joke() { Question = "Do you hear?", Answer = "Yess" };

            var jokeJson = new StringContent(JsonConvert.SerializeObject(joke), Encoding.UTF8, "application/json");
            using (var httpResponse = await ApiHelper.ApiClient.PostAsync(uri.ToString(), jokeJson))
            {
                if (httpResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine(await httpResponse.Content.ReadAsStringAsync());
                }
            }
        }

        public static async Task GetJoke(Uri uri)
        {
            using (var httpResponse = await ApiHelper.ApiClient.GetAsync(uri))
            {
                if (httpResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine(await httpResponse.Content.ReadAsStringAsync());
                }
            }
        }
    }
}
