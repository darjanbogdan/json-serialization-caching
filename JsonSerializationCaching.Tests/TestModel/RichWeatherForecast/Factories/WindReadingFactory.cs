using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class WindReadingFactory : IFakeIdentityItemFactory<WindReading>
    {
        private WindReadingFactory()
        {
        }

        public static WindReadingFactory GetInstance()
        {
            return new WindReadingFactory();
        }

        public WindReading CreateFakeItem(int id)
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
