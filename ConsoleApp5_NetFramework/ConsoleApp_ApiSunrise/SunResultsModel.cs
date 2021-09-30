using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ConsoleApp_ApiSunrise
{
    [DataContract]
    public class SunResultsModel
    {
        [DataMember]
        public DateTime Sunrise { get; set; }
        [DataMember]
        public DateTime Sunset { get; set; }
        [DataMember(Name = "day_length")]
        public TimeSpan DayLength { get; set; }

        public TimeSpan Solar_Noon { get; set; } //won't get mapped
    }
}
