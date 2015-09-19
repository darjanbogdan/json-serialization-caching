using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;
using System;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface IWeatherReading : IIdentity
    {
        ITemperatureReading Temperature { get; }

        IPrecipitationReading Precipitation { get; }

        IHumidityReading Humidity { get; }

        IWindReading Wind { get; }

        int MaxUVIndex { get; }

        /// <summary>
        /// Pressure in hPa
        /// </summary>
        int Pressure { get; }

        /// <summary>
        /// Thunderstorms' percentage
        /// </summary>
        int Thunderstorms { get; }

        /// <summary>
        /// Visibility in km
        /// </summary>
        int Visibility { get; }

        CloudType Clouds { get; }

        /// <summary>
        /// Exact date and time of the current reading
        /// </summary>
        DateTime DateAndTime { get; }

        string Description { get; }

        string ShortDescription { get; }
    }
}
