using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface IWeatherStation : IIdentity
    {
        ILocation Location { get; }

        ICity City { get; }

        List<IWeatherReading> WeatherReadings { get; }
    }
}
