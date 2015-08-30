using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public static class LocationFactory
    {
        public static Location GetRandomLocation()
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
