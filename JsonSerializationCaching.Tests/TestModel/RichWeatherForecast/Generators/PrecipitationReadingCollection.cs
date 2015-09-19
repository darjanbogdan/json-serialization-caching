using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class PrecipitationReadingCollection : BaseDataGenerator<IPrecipitationReading>
    {
        private Lazy<PrecipitationReadingFactory> precipitationFactory = new Lazy<PrecipitationReadingFactory>(() => PrecipitationReadingFactory.GetInstance());

        public PrecipitationReadingCollection(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override IPrecipitationReading CreateDataObject(int i)
        {
            return this.precipitationFactory.Value.CreateFakeItem(i);
        }
    }
}
