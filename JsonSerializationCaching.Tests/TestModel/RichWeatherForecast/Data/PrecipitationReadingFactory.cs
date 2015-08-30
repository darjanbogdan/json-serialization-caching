using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class PrecipitationReadingFactory : DataFactory<PrecipitationReading>
    {
        private static PrecipitationReadingFactory instance;

        private int collectionLength;

        private PrecipitationReadingFactory(int collectionLength)
        {
            this.collectionLength = collectionLength;
        }

        public static PrecipitationReadingFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new PrecipitationReadingFactory(collectionLength);
            return instance;
        }

        protected override void Populate(List<PrecipitationReading> data)
        {
            var precipitations = new List<PrecipitationReading>()
            {
                new PrecipitationReading()
                {
                    Id = 1,
                    Rain = 20,
                    Ice = 0,
                    Snow = 0,
                    HoursOfRain = 2,
                    HoursOverall = 2
                },
                new PrecipitationReading()
                {
                    Id = 2,
                    Rain = 10,
                    Ice = 5,
                    Snow = 0,
                    HoursOfRain = 1,
                    HoursOverall = 4
                },
                new PrecipitationReading()
                {
                    Id = 3,
                    Rain = 4,
                    Ice = 10,
                    Snow = 0,
                    HoursOfRain = 1,
                    HoursOverall = 4
                },
                new PrecipitationReading()
                {
                    Id = 4,
                    Rain = 0,
                    Ice = 0,
                    Snow = 200,
                    HoursOfRain = 0,
                    HoursOverall = 10
                },
                new PrecipitationReading()
                {
                    Id = 5,
                    Rain = 0,
                    Ice = 10,
                    Snow = 5,
                    HoursOfRain = 0,
                    HoursOverall = 10
                },
                new PrecipitationReading()
                {
                    Id = 6,
                    Rain = 10,
                    Ice = 2,
                    Snow = 7,
                    HoursOfRain = 11,
                    HoursOverall = 17
                },
            };
        }
    }
}
