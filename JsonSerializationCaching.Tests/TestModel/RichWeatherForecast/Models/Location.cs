using System;
using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class Location : CachingSerializable, ILocation
    {
        public ICoordinate Latitude { get; set; }
        public ICoordinate Longitude { get; set; }
    }

    public class Coordinate : CachingSerializable, ICoordinate
    {
        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double Decimal { get; set; }
    }
}
