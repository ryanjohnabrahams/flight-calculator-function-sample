using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Function
{
    public class FlightLine
    {
        [JsonPropertyName("destination")]
        public string Destination { get; set; }
        [JsonPropertyName("returnTrip")]
        public bool ReturnTrip { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
    }
}
