using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class TemperatureReadingFactory : IFakeIdentityItemFactory<TemperatureReading>
    {
        private TemperatureReadingFactory()
        {
        }

        public static TemperatureReadingFactory GetInstace()
        {
            return new TemperatureReadingFactory();
        }

        public TemperatureReading CreateFakeItem(int id)
        {
            return new TemperatureReading()
            {
                Id = id,
                Description = Utils.GetRandomEnumValue<TemperatureDescription>(),
                DewPoint = Utils.GetRandomNumber(25),
                Temperature = Utils.GetRandomNumber(50),
                ReelFeel = Utils.GetRandomNumber(50),
            };
        }
    }
}
