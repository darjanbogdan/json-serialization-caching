using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System.Linq;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class WeatherStationFactory : FakeFactory<WeatherStationFactory, WeatherStation>
    {
        public WeatherStationFactory()
        {
            CityGenerator.Instance.PopulateCollection();
        }

        public override WeatherStation CreateFakeItem(int id)
        {
            return new WeatherStation()
            {
                Id = id,
                City = CityGenerator.Instance.GetRandomItem(),
                Location = LocationFactory.Instance.CreateFakeItem(),
                WeatherReadings = WeatherReadingGenerator.GetInstance(100).DataCollection.ToList()
            };
        }
    }
}
