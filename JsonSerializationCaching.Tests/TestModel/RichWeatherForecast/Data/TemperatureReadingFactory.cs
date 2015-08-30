using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class TemperatureReadingFactory : DataFactory<TemperatureReading>
    {
        private static TemperatureReadingFactory instance;

        private int collectionLength;

        private TemperatureReadingFactory(int collectionLength)
        {
            this.collectionLength = collectionLength;
        }

        public static TemperatureReadingFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new TemperatureReadingFactory(collectionLength);
            return instance;
        }

        protected override void Populate(List<TemperatureReading> data)
        {
            for (int i = 0; i < this.collectionLength; i++)
            {
                data.Add(new TemperatureReading()
                {
                    Id = i,
                    Description = Utils.GetRandomEnumValue<TemperatureDescription>(),
                    DewPoint = Utils.GetRandomNumber(25),
                    Temperature = Utils.GetRandomNumber(50),
                    ReelFeel = Utils.GetRandomNumber(50),
                });
            }
        }
    }
}
