using Fnproject.Fn.Fdk;
using System.Collections.Generic ;
using System.Text.Json;

using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System;

[assembly:InternalsVisibleTo("Function.Tests")]
namespace Function {
    public class FlightBooker {
        
        public string BookFlight(string input) {
            
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                var fi = JsonSerializer.Deserialize<FlightInput>(input);
                return JsonSerializer.Serialize(new FlightOutput(fi), options);

            }
            catch (Exception ex) {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                return JsonSerializer.Serialize(new FlightError(), options);
            }
        }

        static void Main(string[] args) { Fdk.Handle(args[0]) ;}
    }
}