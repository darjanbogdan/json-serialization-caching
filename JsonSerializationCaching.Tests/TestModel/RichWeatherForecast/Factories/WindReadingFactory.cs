using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class WindReadingFactory : FakeFactory<WindReadingFactory, WindReading>
    {
        public override WindReading CreateFakeItem(int id)
        {
            return new WindReading()
            {
                Id = id,
                BeaufortNumber = Utils.GetRandomNumber(13),
                Description = Utils.GetRandomEnumValue<WindDescription>(),
                Direction = Utils.GetRandomEnumValue<WindDirection>(),
                Gust = Utils.GetRandomNumber(250),
                Speed = Utils.GetRandomNumber(220)
            };
        }
    }
}
