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

        public dynamic BookFlight(string input)  //dynamic ctx
        {
            return input.GetType();//ctx.GetType();
            /*
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
            */
        }

        static void Main(string[] args) { Fdk.Handle(args[0]) ;}
    }
}