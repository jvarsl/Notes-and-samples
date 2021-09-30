using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BtcPriceApi.Models
{
    [DataContract]
    public abstract class CurrencyModel
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Rate { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember(Name = "rate_float")]
        public double RateFloat { get; set; }
    }
}
