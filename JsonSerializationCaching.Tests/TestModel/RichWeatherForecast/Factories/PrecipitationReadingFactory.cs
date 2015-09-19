using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class PrecipitationReadingFactory : IFakeIdentityItemFactory<PrecipitationReading>
    {
        private PrecipitationReadingFactory()
        {
        }

        public static PrecipitationReadingFactory GetInstance()
        {
            return new PrecipitationReadingFactory();
        }

        public PrecipitationReading CreateFakeItem(int id)
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
