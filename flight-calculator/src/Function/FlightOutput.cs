using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Function
{
    public class FlightOutput
    {
        [JsonPropertyName("bookingName")]
        public string BookingName { get; private set; }
        [JsonPropertyName("lineItemCount")]
        public int LineItemCount { get; private set; }
        [JsonPropertyName("cost")]
        public double Cost { get; private set; }
        [JsonPropertyName("taxPercentage")]
        public double TaxPercentage { get => 13.5d; }
        [JsonPropertyName("tax")]
        public double Tax { get => Math.Round(Cost * (TaxPercentage / 100), 2); }
        [JsonPropertyName("total")]
        public double Total { get => Math.Round(Cost + Cost * (TaxPercentage / 100), 2); }

        public FlightOutput(FlightInput input)
        {
            BookingName = input.FirstName + " " + input.LastName + " of " + input.Business;
            LineItemCount = input.Lines.Count;
            foreach (FlightLine line in input.Lines)
            {
                Cost += line.Price;
            }
        }
    }
}
