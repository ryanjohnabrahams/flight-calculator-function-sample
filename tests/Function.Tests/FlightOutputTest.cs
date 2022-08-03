using System;
using System.Text.Json.Serialization;

namespace Function.Tests
{
    public class FlightOutputTest
    {
        [JsonPropertyName("bookingName")]
        public string BookingName { get; set; }
        [JsonPropertyName("lineItemCount")]
        public int LineItemCount { get; set; }
        [JsonPropertyName("cost")]
        public double Cost { get; set; }
        [JsonPropertyName("taxPercentage")]
        public double TaxPercentage { get; set; }
        [JsonPropertyName("tax")]
        public double Tax { get; set; }
        [JsonPropertyName("total")]
        public double Total { get; set; }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            if ((obj as FlightOutputTest).BookingName != this.BookingName) return false;
            if ((obj as FlightOutputTest).LineItemCount != this.LineItemCount) return false;
            if ((obj as FlightOutputTest).Cost != this.Cost) return false;
            if ((obj as FlightOutputTest).TaxPercentage != this.TaxPercentage) return false;
            if ((obj as FlightOutputTest).Tax != this.Tax) return false;
            if ((obj as FlightOutputTest).Total != this.Total) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BookingName, LineItemCount, Cost, TaxPercentage, Tax, Total);
        }
    }
}
