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

        private PrecipitationReadingFactory(int collectionLength)
            : base(collectionLength)
        {
        }

        public static PrecipitationReadingFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new PrecipitationReadingFactory(collectionLength);
            return instance;
        }

        protected override PrecipitationReading CreateItem(int id)
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

        protected override void Populate(List<PrecipitationReading> data)
        {
            for (int i = 0; i < this.DataCollectionlength; i++)
            {
                data.Add(this.CreateItem(i));
            }
        }
    }
}
