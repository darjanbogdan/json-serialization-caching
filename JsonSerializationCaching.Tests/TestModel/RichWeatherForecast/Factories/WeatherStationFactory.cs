using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System.Linq;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class WeatherStationFactory : IFakeIdentityItemFactory<WeatherStation>
    {
        private LocationFactory locationFactory;
        private CityCollection cityCollection;
        private WeatherReadingCollection weatherCollection;

        private WeatherStationFactory()
        {
            locationFactory = LocationFactory.GetInstance();
            this.cityCollection = new CityCollection();
            this.weatherCollection = new WeatherReadingCollection(50);
        }

        public static WeatherStationFactory GetInstance()
        {
            return new WeatherStationFactory();
        }

        public WeatherStation CreateFakeItem(int id)
        {
            return new WeatherStation()
            {
                Id = id,
                City = cityCollection.GetRandomItem(),
                Location = locationFactory.CreateFakeItem(),
                WeatherReadings = weatherCollection.GetAll().ToList()
            };
        }
    }
}
