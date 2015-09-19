using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class WindReading : CachingSerializable, IWindReading
    {
        public int Id { get; set; }

        /// <summary>
        /// Speed in KM/h
        /// </summary>
        public int Speed { get; set; }

        public int BeaufortNumber { get; set; }

        /// <summary>
        /// Gust in KM/h
        /// </summary>
        public int Gust { get; set; }

        public WindDirection Direction { get; set; }

        public WindDescription Description { get; set; }
    }
}
