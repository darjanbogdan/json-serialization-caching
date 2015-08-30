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
        private int collectionLength;

        private WeatherReadingFactory(int collectionLength)
        {
            this.collectionLength = collectionLength;
        }

        public static WeatherReadingFactory GetInstance(int collectionLength)
        {
            return new WeatherReadingFactory(collectionLength);
        }

        protected override void Populate(List<WeatherReading> data)
        {
            var precipitationFactory = PrecipitationReadingFactory.GetInstance(100);
            var temperatureFactory = TemperatureReadingFactory.GetInstance(100);
            var humidityFactory = HumidityReadingFactory.GetInstance(100);
            var windFactory = WindReadingFactory.GetInstance(100);

            for (int i = 0; i < this.collectionLength; i++)
            {
                data.Add(new WeatherReading()
                {
                    Id = i,
                    Clouds = Utils.GetRandomEnumValue<CloudType>(),
                    DateAndTime = Utils.GetRandomDate(),
                    Description = Utils.GetRandomString(150),
                    ShortDescription = Utils.GetRandomString(40),
                    MaxUVIndex = Utils.GetRandomNumber(10),
                    Pressure = Utils.GetRandomNumber(1200),
                    Visibility = Utils.GetRandomNumber(20),
                    Thunderstorms = Utils.GetRandomNumber(101),
                    Precipitation = precipitationFactory.GetRandomItem(),
                    Temperature = temperatureFactory.GetRandomItem(),
                    Humidity = humidityFactory.GetRandomItem(),
                    Wind = windFactory.GetRandomItem()
                });
            }
        }
    }
}
