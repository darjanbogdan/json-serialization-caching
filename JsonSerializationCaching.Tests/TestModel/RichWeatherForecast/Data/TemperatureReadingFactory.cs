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

        private TemperatureReadingFactory()
        {
        }

        public static TemperatureReadingFactory GetInstance()
        {
            if (instance == null)
                instance = new TemperatureReadingFactory();
            return instance;
        }

        public override TemperatureReading CreateItem(int id)
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

        protected override void Populate(List<TemperatureReading> data)
        {
            for (int i = 0; i < this.DataCollectionlength; i++)
            {
                data.Add(this.CreateItem(i));
            }
        }
    }
}
