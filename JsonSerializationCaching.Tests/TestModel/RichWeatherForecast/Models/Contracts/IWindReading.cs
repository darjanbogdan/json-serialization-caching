using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface IWindReading : IIdentity
    {
        /// <summary>
        /// Speed in KM/h
        /// </summary>
        int Speed { get; }

        int BeaufortNumber { get; }

        /// <summary>
        /// Gust in KM/h
        /// </summary>
        int Gust { get; set; }

        WindDirection Direction { get; }

        WindDescription Description { get; }
    }
}
