using System;
using System.Runtime.Serialization;

namespace ConsoleApp_BtcPriceApi.Models
{
    [DataContract]
    public class TimeModel
    {
        [DataMember(Name = "updatedISO")]
        public DateTime Updated { get; set; }
    }
}