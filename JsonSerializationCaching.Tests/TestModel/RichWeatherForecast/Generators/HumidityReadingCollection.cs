using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class HumidityReadingCollection : BaseDataGenerator<IHumidityReading>
    {
        private Lazy<HumidityReadingFactory> humidityFactory =  new Lazy<HumidityReadingFactory>(() => HumidityReadingFactory.GetInstance());

        public HumidityReadingCollection(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override IHumidityReading CreateDataObject(int i)
        {
            return this.humidityFactory.Value.CreateFakeItem(i);
        }
    }
}
