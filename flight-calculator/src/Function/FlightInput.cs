using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Function
{
    public class FlightInput
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("business")]
        public string Business { get; set; }
        [JsonPropertyName("lines")]
        public ICollection<FlightLine> Lines { get; set; }
    }
}
