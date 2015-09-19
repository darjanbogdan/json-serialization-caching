using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class TemperatureReadingCollection : BaseDataGenerator<ITemperatureReading>
    {
        private Lazy<TemperatureReadingFactory> temperatureFactory = new Lazy<TemperatureReadingFactory>(() => TemperatureReadingFactory.GetInstace());

        public TemperatureReadingCollection(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override ITemperatureReading CreateDataObject(int i)
        {
            return this.temperatureFactory.Value.CreateFakeItem(i);
        }
    }
}
