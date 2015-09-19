using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class LocationFactory : IFakeItemFactory<Location>
    {
        private LocationFactory()
        { }

        public static LocationFactory GetInstance()
        {
            return new LocationFactory();
        }

        public Location CreateFakeItem()
        {
            return new Location()
            {
                Latitude = new Coordinate()
                {
                    Degrees = Utils.GetRandomNumber(181),
                    Minutes = Utils.GetRandomNumber(61),
                    Seconds = Utils.GetRandomNumber(61)
                },
                Longitude = new Coordinate()
                {
                    Degrees = Utils.GetRandomNumber(181),
                    Minutes = Utils.GetRandomNumber(61),
                    Seconds = Utils.GetRandomNumber(61)
                }
            };
        }
    }
}
