using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class WeatherStationCollection : BaseDataGenerator<IWeatherStation>
    {
        private Lazy<WeatherStationFactory> weatherStationFactory = new Lazy<WeatherStationFactory>(() => WeatherStationFactory.GetInstance());

        public WeatherStationCollection(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override IWeatherStation CreateDataObject(int i)
        {
            return this.weatherStationFactory.Value.CreateFakeItem(i);
        }
    }
}
