using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class WeatherReadingFactory : IFakeIdentityItemFactory<WeatherReading>
    {
        private HumidityReadingCollection humidityCollection;
        private TemperatureReadingCollection temperatureCollection;
        private WindReadingCollection windCollection;
        private PrecipitationReadingCollection precipitationCollection;
        
        private WeatherReadingFactory()
        {
            this.humidityCollection = new HumidityReadingCollection(20);
            this.precipitationCollection = new PrecipitationReadingCollection(20);
            this.temperatureCollection = new TemperatureReadingCollection(20);
            this.windCollection = new WindReadingCollection(20);
        }

        public static WeatherReadingFactory GetInstance()
        {
            return new WeatherReadingFactory();
        }

        public WeatherReading CreateFakeItem(int id)
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
                Humidity = this.humidityCollection.GetRandomItem(),
                Precipitation = this.precipitationCollection.GetRandomItem(),
                Temperature = this.temperatureCollection.GetRandomItem(),
                Wind = this.windCollection.GetRandomItem()
            };
        }
    }
}
