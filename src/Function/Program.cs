using Fnproject.Fn.Fdk;
using System.Collections.Generic ;
using System.Text.Json;

using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System;
using Fnproject.Fn.Fdk.Context;

[assembly:InternalsVisibleTo("Function.Tests")]
namespace Function {
    public class FlightBooker {       

        public string BookFlight(string input, IHTTPContext ctx) 
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                var fi = JsonSerializer.Deserialize<FlightInput>(input);
                return JsonSerializer.Serialize(new FlightOutput(fi), options);

            }
            catch (Exception ex) {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                ctx.SetStatus(400);
                FlightError fe = new FlightError { Message = "You gave me: " + input };
                return JsonSerializer.Serialize(fe, options);
            }
        }

        static void Main(string[] args) { Fdk.Handle(args[0]) ;}
    }
}