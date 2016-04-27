using Newtonsoft.Json;

namespace GoogleMapAPI.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Viewport
    {
        [JsonProperty("northeast")]
        public NorthEast Northeast { get; set; }
        [JsonProperty("southwest")]
        public SouthWest Southwest { get; set; }
    }
}
