using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class WeatherStationFactory : DataFactory<WeatherStation>
    {
        private int collectionLength;

        private WeatherStationFactory(int collectionLength)
        {
            this.collectionLength = collectionLength;
        }

        public static WeatherStationFactory GetInstance(int collectionLength)
        {
            return new WeatherStationFactory(collectionLength);
        }

        protected override void Populate(List<WeatherStation> data)
        {
            var cityFactory = CityFactory.GetInstance(0);
            var weatherReadingsFactory = WeatherReadingFactory.GetInstance(1000);
            for (int i = 0; i < this.collectionLength; i++)
            {
                data.Add(new WeatherStation()
                {
                    Id = i,
                    City = cityFactory.GetRandomItem(),
                    Location = LocationFactory.GetRandomLocation(),
                    WeatherReadings = weatherReadingsFactory.DataCollection
                });
            }
        }
    }
}
