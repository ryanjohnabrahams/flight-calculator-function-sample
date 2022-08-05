using System.Text.Json.Serialization;

namespace Function
{
    public class FlightError
    {
        [JsonPropertyName("error")]
        public string Error { get => "Bad Request"; }
        [JsonPropertyName("message")]
        public string Message { get; set; }

    }
}
