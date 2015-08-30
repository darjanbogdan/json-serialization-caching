using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class Location : CachingSerializable
    {
        public Coordinate Latitude { get; set; }
        public Coordinate Longitude { get; set; }
    }

    public class Coordinate : CachingSerializable
    {
        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double Decimal { get; set; }
    }
}
