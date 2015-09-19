using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class WindReadingCollection : BaseDataGenerator<IWindReading>
    {
        private Lazy<WindReadingFactory> windFactory = new Lazy<WindReadingFactory>(() => WindReadingFactory.GetInstance());

        public WindReadingCollection(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override IWindReading CreateDataObject(int i)
        {
            return this.windFactory.Value.CreateFakeItem(i);
        }
    }
}
