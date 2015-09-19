using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface ITemperatureReading : IIdentity
    {
        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        int Temperature { get; }
        
        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        int ReelFeel { get; }

        /// <summary>
        /// Dew point in Celsius
        /// </summary>
        int DewPoint { get; }

        TemperatureDescription Description { get; }
    }
}
