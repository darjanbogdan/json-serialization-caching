using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class HumidityReadingFactory : FakeFactory<HumidityReadingFactory, HumidityReading>
    {
        public override HumidityReading CreateFakeItem(int id)
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
