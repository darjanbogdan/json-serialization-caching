using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories
{
    public class TemperatureReadingFactory : FakeFactory<TemperatureReadingFactory, TemperatureReading>
    {
        public override TemperatureReading CreateFakeItem(int id)
        {
            return new TemperatureReading()
            {
                Id = id,
                Description = Utils.GetRandomEnumValue<TemperatureDescription>(),
                DewPoint = Utils.GetRandomNumber(25),
                Temperature = Utils.GetRandomNumber(50),
                ReelFeel = Utils.GetRandomNumber(50),
            };
        }
    }
}
