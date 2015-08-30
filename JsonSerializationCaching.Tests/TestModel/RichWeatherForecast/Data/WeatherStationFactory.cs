using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class WeatherStationFactory : DataFactory<WeatherStation>
    {
        private WeatherStationFactory()
        {
        }

        public static WeatherStationFactory GetInstance()
        {
            return new WeatherStationFactory();
        }

        public override WeatherStation CreateItem(int id)
        {
            var cityFactory = CityFactory.GetInstance();
            var weatherReadingFactory = WeatherReadingFactory.GetInstance();
            weatherReadingFactory.Initialize(1000);

            return new WeatherStation()
            {
                Id = id,
                City = cityFactory.GetRandomItem(),
                Location = LocationFactory.GetRandomLocation(),
                WeatherReadings = weatherReadingFactory.DataCollection.ToList()
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
