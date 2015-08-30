using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class HumidityReadingFactory : DataFactory<HumidityReading>
    {
        private static HumidityReadingFactory instance;

        private int collectionLength;

        private HumidityReadingFactory(int collectionLength)
        {
            this.collectionLength = collectionLength;
        }

        public static HumidityReadingFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new HumidityReadingFactory(collectionLength);
            return instance;
        }

        protected override void Populate(List<HumidityReading> data)
        {
            for (int i = 0; i < this.collectionLength; i++)
            {
                data.Add(new HumidityReading()
                {
                    Id = i,
                    Description = Utils.GetRandomEnumValue<HumidityDescription>(),
                    Humidity = Utils.GetRandomNumber(101)
                });
            }
        }
    }
}
