using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class WeatherStationFactory : DataFactory<WeatherStation>
    {
        private WeatherStationFactory(int collectionLength)
            : base(collectionLength)
        {
        }

        public static WeatherStationFactory GetInstance(int collectionLength)
        {
            return new WeatherStationFactory(collectionLength);
        }

        protected override WeatherStation CreateItem(int id)
        {
            var cityFactory = CityFactory.GetInstance(0);

            return new WeatherStation()
            {
                Id = id,
                City = cityFactory.GetRandomItem(),
                Location = LocationFactory.GetRandomLocation(),
                WeatherReadings = WeatherReadingFactory.GetInstance(1000).DataCollection.ToList()
            };
        }

        protected override void Populate(List<WeatherStation> data)
        {
            for (int i = 0; i < this.DataCollectionlength; i++)
            {
                data.Add(this.CreateItem(i));
            }
        }
    }
}
