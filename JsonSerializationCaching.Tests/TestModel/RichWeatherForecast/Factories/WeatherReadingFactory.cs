using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class WeatherReadingFactory : FakeFactory<WeatherReadingFactory, WeatherReading>
    {
        public WeatherReadingFactory()
        {
            HumidityReadingGenerator.Instance.PopulateCollection(100);
            PrecipitationReadingGenerator.Instance.PopulateCollection(100);
            TemperatureReadingGenerator.Instance.PopulateCollection(100);
            WindReadingGenerator.Instance.PopulateCollection(100);
        }

        public override WeatherReading CreateFakeItem(int id)
        {
            return new WeatherReading()
            {
                Id = id,
                DateAndTime = Utils.GetRandomDate(),
                Clouds = Utils.GetRandomEnumValue<CloudType>(),
                Description = Utils.GetRandomString(150),
                ShortDescription = Utils.GetRandomString(),
                MaxUVIndex = Utils.GetRandomNumber(10),
                Pressure = Utils.GetRandomNumber(1200),
                Thunderstorms = Utils.GetRandomNumber(101),
                Visibility = Utils.GetRandomNumber(20),
                Humidity = HumidityReadingGenerator.Instance.GetRandomItem(),
                Precipitation = PrecipitationReadingGenerator.Instance.GetRandomItem(),
                Temperature = TemperatureReadingGenerator.Instance.GetRandomItem(),
                Wind = WindReadingGenerator.Instance.GetRandomItem()
            };
        }
    }
}
