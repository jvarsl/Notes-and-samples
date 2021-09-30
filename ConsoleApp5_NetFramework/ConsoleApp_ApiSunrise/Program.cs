using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ApiSunrise
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper.InitiliazeClient();
            var model = await new SunProcessor().LoadModelAsync();
            Console.WriteLine(model.Results.DayLength);
            Console.WriteLine(model.Status);
            Console.ReadKey();
        }
    }
}
