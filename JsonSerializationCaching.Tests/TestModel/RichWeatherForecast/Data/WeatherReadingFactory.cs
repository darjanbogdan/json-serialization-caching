using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class WeatherReadingFactory : DataFactory<WeatherReading>
    {
        private WeatherReadingFactory()
        {
        }

        public static WeatherReadingFactory GetInstance()
        {
            return new WeatherReadingFactory();
        }

        public override WeatherReading CreateItem(int id)
        {
            return new WeatherReading()
            {
                Id = id,
                Clouds = Utils.GetRandomEnumValue<CloudType>(),
                DateAndTime = Utils.GetRandomDate(),
                Description = Utils.GetRandomString(150),
                ShortDescription = Utils.GetRandomString(40),
                MaxUVIndex = Utils.GetRandomNumber(10),
                Pressure = Utils.GetRandomNumber(1200),
                Visibility = Utils.GetRandomNumber(20),
                Thunderstorms = Utils.GetRandomNumber(101),
                Precipitation = PrecipitationReadingFactory.GetInstance().GetRandomItem(),
                Temperature = TemperatureReadingFactory.GetInstance().GetRandomItem(),
                Humidity = HumidityReadingFactory.GetInstance().GetRandomItem(),
                Wind = WindReadingFactory.GetInstance().GetRandomItem()
            };
        }

        protected override void Populate(List<WeatherReading> data)
        {
            for (int i = 0; i < this.DataCollectionlength; i++)
            {
                data.Add(this.CreateItem(i));
            }
        }
    }
}
