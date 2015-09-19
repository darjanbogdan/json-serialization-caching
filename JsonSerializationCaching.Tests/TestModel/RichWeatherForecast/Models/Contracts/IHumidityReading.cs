using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface IHumidityReading : IIdentity
    {
        /// <summary>
        /// Humidity in percentage
        /// </summary>
        int Humidity { get; }

        HumidityDescription Description { get; }
    }
}
