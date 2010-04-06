using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Britannic.Web.Models
{
    public class Artist
    {
        public string Name { get; set; }
        [JsonProperty("photo")]
        public IList<string> Photos { get; set; }
        public IList<string> Tags { get; set; }
        public string Website { get; set; }
    }
}