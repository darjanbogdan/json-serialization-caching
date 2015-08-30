using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class WindReadingFactory : DataFactory<WindReading>
    {
        private static WindReadingFactory instance;

        private int collectionLength;

        private WindReadingFactory(int collectionLength)
        {
            this.collectionLength = collectionLength;
        }

        public static WindReadingFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new WindReadingFactory(collectionLength);
            return instance;
        }

        protected override void Populate(List<WindReading> data)
        {
            for (int i = 0; i < this.collectionLength; i++)
            {
                data.Add(new WindReading()
                {
                    Id = i,
                    BeaufortNumber = Utils.GetRandomNumber(13),
                    Description = Utils.GetRandomEnumValue<WindDescription>(),
                    Direction = Utils.GetRandomEnumValue<WindDirection>(),
                    Gust = Utils.GetRandomNumber(250),
                    Speed = Utils.GetRandomNumber(220)
                });
            }
        }
    }
}
