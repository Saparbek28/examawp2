using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examwpf2
{
    public class Featur
    {
        [JsonProperty("features")]
        public IList<Feature> Features { get; set; }
    }
}
