using JsonSerializationCaching.Serialization;

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
