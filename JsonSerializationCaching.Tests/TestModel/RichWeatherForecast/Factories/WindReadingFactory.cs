using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
