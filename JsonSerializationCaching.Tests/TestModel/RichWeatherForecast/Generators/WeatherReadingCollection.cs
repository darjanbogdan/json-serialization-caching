using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class WeatherReadingCollection : BaseDataGenerator<IWeatherReading>
    {
        private Lazy<WeatherReadingFactory> weatherFactory = new Lazy<WeatherReadingFactory>(() => WeatherReadingFactory.GetInstance());
        
        public WeatherReadingCollection(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override IWeatherReading CreateDataObject(int i)
        {
            return this.weatherFactory.Value.CreateFakeItem(i);
        }
    }
}
