

namespace ConsoleApp_BtcPriceApi.Models
{
    public class CurrenciesModel
    {
        public USDCurrencyModel USD { get; set; }
        public GBPCurrencyModel GBP { get; set; }
        public EURCurrencyModel EUR { get; set; }
    }
}
/*
 {
   "time":{
      "updated":"Sep 27, 2021 14:22:00 UTC",
      "updatedISO":"2021-09-27T14:22:00+00:00",
      "updateduk":"Sep 27, 2021 at 15:22 BST"
   },
   "disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org",
   "chartName":"Bitcoin",
   "bpi":{
      "USD":{
         "code":"USD",
         "symbol":"&#36;",
         "rate":"43,480.6963",
         "description":"United States Dollar",
         "rate_float":43480.6963
      },
      "GBP":{
         "code":"GBP",
         "symbol":"&pound;",
         "rate":"31,694.9492",
         "description":"British Pound Sterling",
         "rate_float":31694.9492
      },
      "EUR":{
         "code":"EUR",
         "symbol":"&euro;",
         "rate":"37,156.1681",
         "description":"Euro",
         "rate_float":37156.1681
      }
   }
}
 */