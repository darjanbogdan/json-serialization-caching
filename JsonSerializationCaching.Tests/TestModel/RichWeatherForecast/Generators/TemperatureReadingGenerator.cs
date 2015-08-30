using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class TemperatureReadingGenerator : SingletonDataGenerator<TemperatureReadingGenerator, TemperatureReading>
    {
        public override void PopulateCollection(int? collectionLength = null)
        {
            int length = collectionLength.HasValue ? collectionLength.Value : 10;
            var collection = new List<TemperatureReading>();
            for (int i = 0; i < length; i++)
            {
                collection.Add(TemperatureReadingFactory.Instance.CreateFakeItem(i));
            }
            this.DataCollection = collection;
        }
    }
}
