using Newtonsoft.Json;

namespace GoogleMapAPI.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Geometry
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
        [JsonProperty("viewport")]
        public Viewport Viewport { get; set; }
    }

}
