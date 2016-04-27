using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapAPI.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GoogleModel
    {

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
