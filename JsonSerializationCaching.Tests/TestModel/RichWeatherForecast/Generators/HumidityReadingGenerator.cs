﻿using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class HumidityReadingGenerator : SingletonDataGenerator<HumidityReadingGenerator, HumidityReading>
    {
        public override void PopulateCollection(int? collectionLength = null)
        {
            int length = collectionLength.HasValue ? collectionLength.Value : 10;
            var collection = new List<HumidityReading>();
            for (int i = 0; i < length; i++)
            {
                collection.Add(HumidityReadingFactory.Instance.CreateFakeItem(i));
            }
            this.DataCollection = collection;
        }
    }
}
