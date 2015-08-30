using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class TemperatureReadingFactory : FakeFactory<TemperatureReadingFactory, TemperatureReading>
    {
        public override TemperatureReading CreateFakeItem(int id)
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
