using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class HumidityReading : CachingSerializable, IHumidityReading
    {
        public int Id { get; set; }

        /// <summary>
        /// Humidity in percentage
        /// </summary>
        public int Humidity { get; set; }

        public HumidityDescription Description { get; set; }
    }
}
