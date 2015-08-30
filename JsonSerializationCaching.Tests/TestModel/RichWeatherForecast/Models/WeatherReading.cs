using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class WeatherReading : CachingSerializable, IIdentity
    {
        public int Id { get; set; }

        public TemperatureReading Temperature { get; set; }

        public PrecipitationReading Precipitation { get; set; }

        public HumidityReading Humidity { get; set; }

        public WindReading Wind { get; set; }

        public int MaxUVIndex { get; set; }

        /// <summary>
        /// Pressure in hPa
        /// </summary>
        public int Pressure { get; set; }

        /// <summary>
        /// Thunderstorms' percentage
        /// </summary>
        public int Thunderstorms { get; set; }

        /// <summary>
        /// Visibility in km
        /// </summary>
        public int Visibility { get; set; }

        public CloudType Clouds { get; set; }

        /// <summary>
        /// Exact date and time of the current reading
        /// </summary>
        public DateTime DateAndTime { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }
    }

    public enum CloudType
    {
        Cirrocumulus,
        Altocumulus,
        Cumulonimbus,
        Cumulus,
        Cirrus,
        Cirrostratus,
        Altostratus,
        Nimbostratus,
        Stratocumulus,
        Stratus,
        None
    }
}
