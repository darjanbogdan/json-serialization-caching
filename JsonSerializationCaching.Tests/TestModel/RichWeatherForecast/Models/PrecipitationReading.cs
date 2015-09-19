using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class PrecipitationReading : CachingSerializable, IPrecipitationReading
    {
        public int Id { get; set; }

        /// <summary>
        /// Rain in mm
        /// </summary>
        public int Rain { get; set; }

        /// <summary>
        /// Snow in cm
        /// </summary>
        public int Snow { get; set; }

        /// <summary>
        /// Ice in mm
        /// </summary>
        public int Ice { get; set; }

        public int HoursOfRain { get; set; }

        /// <summary>
        /// Hours of percipitation
        /// </summary>
        public int HoursOverall { get; set; }
    }
}
