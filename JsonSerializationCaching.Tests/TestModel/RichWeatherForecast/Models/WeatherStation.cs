using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class WeatherStation : CachingSerializable, IWeatherStation
    {
        public int Id { get; set; }

        public ILocation Location { get; set; }

        public ICity City { get; set; }

        public List<IWeatherReading> WeatherReadings { get; set; }
    }
}
