using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class LocationFactory : FakeFactory<LocationFactory, Location>
    {
        public override Location CreateFakeItem(int id)
        {
            return CreateFakeItem();
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
