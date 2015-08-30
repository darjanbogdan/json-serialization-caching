using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
