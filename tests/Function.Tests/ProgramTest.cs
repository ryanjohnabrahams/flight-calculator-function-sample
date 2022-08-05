using Function;
using NUnit.Framework;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Function.Tests {
    public class FlightBookerTest
    {
        /*[Test]
        public void GivenValidJsonShouldReturnValidJson()
        {
            string inJson = "{\"firstName\": \"Ted\",\"lastName\": \"Cruz\",\"business\": \"Cancun Cruzes\",\"lines\":[{\"destination\": \"anywhere but texas\",\"returnTrip\": false,\"price\": 895.95},{\"destination\": \"Montana\",\"returnTrip\": true,\"price\": 1024.20}]}";
            FlightOutputTest ft = new FlightOutputTest { 
                BookingName = "Ted Cruz of Cancun Cruzes", 
                LineItemCount = 2, 
                Cost = 1920.15d, 
                Tax = 259.22d, 
                TaxPercentage = 13.5d, 
                Total = 2179.37d };

            FlightBooker flightBooker = new FlightBooker();
            var fo = JsonSerializer.Deserialize<FlightOutputTest>(flightBooker.BookFlight(inJson));

            Assert.IsTrue(fo.Equals(ft));
        }*/

        /*[Test]
        public void GivenGuffShouldReturnError()
        {
            FlightBooker flightBooker = new FlightBooker();
            var guff = "HEY! This isn't Json at all! You tricked me!";
            var stuff = flightBooker.BookFlight(guff);
 
            var err = JsonSerializer.Deserialize<FlightError>(stuff);
            Assert.IsTrue(err.ErrorCode == 402);
            Assert.IsTrue(err.ErrorDescription.Equals("Bad Request"));
        }
        */
    }
}