using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examwpf2
{
    public class Feature
    {
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Property Properties { get; set; }
    }
}
