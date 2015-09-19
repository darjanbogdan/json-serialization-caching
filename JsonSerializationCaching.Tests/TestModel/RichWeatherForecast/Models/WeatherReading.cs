using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;
using System;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class WeatherReading : CachingSerializable, IWeatherReading
    {
        public int Id { get; set; }

        public ITemperatureReading Temperature { get; set; }

        public IPrecipitationReading Precipitation { get; set; }

        public IHumidityReading Humidity { get; set; }

        public IWindReading Wind { get; set; }

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
}
