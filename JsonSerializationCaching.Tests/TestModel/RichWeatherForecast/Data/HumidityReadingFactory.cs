﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class HumidityReadingFactory : DataFactory<HumidityReading>
    {
        private static HumidityReadingFactory instance;

        private HumidityReadingFactory(int collectionLength)
            : base(collectionLength)
        {
        }

        public static HumidityReadingFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new HumidityReadingFactory(collectionLength);
            return instance;
        }

        protected override HumidityReading CreateItem(int id)
        {
            return new HumidityReading()
            {
                Id = id,
                Description = Utils.GetRandomEnumValue<HumidityDescription>(),
                Humidity = Utils.GetRandomNumber(101)
            };
        }

        protected override void Populate(List<HumidityReading> data)
        {
            for (int i = 0; i < this.DataCollectionlength; i++)
            {
                data.Add(this.CreateItem(i));
            }
        }
    }
}
