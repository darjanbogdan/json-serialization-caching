using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class TemperatureReading : CachingSerializable, ITemperatureReading
    {
        public int Id { get; set; }

        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int Temperature { get; set; }
        
        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int ReelFeel { get; set; }

        /// <summary>
        /// Dew point in Celsius
        /// </summary>
        public int DewPoint { get; set; }

        public TemperatureDescription Description { get; set; }
    }
}
