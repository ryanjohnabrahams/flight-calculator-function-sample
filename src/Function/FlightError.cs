using System.Text.Json.Serialization;

namespace Function
{
    public class FlightError
    {
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get => 402;  }
        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get => "Bad Request"; }


    }
}
