using System;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class HumidityReadingFactory : IFakeIdentityItemFactory<HumidityReading>
    {
        private HumidityReadingFactory()
        { }

        public static HumidityReadingFactory GetInstance()
        {
            return new HumidityReadingFactory();
        }

        public HumidityReading CreateFakeItem(int id)
        {
            return new HumidityReading()
            {
                Id = id,
                Description = Utils.GetRandomEnumValue<HumidityDescription>(),
                Humidity = Utils.GetRandomNumber(101)
            };
        }
    }
}
