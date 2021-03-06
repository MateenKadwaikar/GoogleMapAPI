﻿using Newtonsoft.Json;

namespace GoogleMapAPI.Model
{

    [JsonObject(MemberSerialization.OptIn)]
    public class SouthWest
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}
