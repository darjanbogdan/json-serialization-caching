using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class PrecipitationReadingFactory : FakeFactory<PrecipitationReadingFactory, PrecipitationReading>
    {
        public override PrecipitationReading CreateFakeItem(int id)
        {
            return new PrecipitationReading()
            {
                Id = id,
                HoursOfRain = Utils.GetRandomNumber(25),
                HoursOverall = Utils.GetRandomNumber(25),
                Ice = Utils.GetRandomNumber(2),
                Rain = Utils.GetRandomNumber(10),
                Snow = Utils.GetRandomNumber(150)
            };
        }
    }
}
