using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examwpf2
{
    public class Property
    {
        [JsonProperty("mag")]
        public Decimal Magnitude { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("time")]

        public DateTime Time { get; set; }
        [JsonProperty("dmin")]
        public Decimal? Dmin { get; set; }
    }
}
