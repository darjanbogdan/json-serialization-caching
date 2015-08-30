using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public abstract class SingletonDataGenerator<TGenerator, TData> : DataGenerator<TData>
        where TData : IIdentity
        where TGenerator : class, new()
    {
        private readonly static TGenerator instance = new TGenerator();

        public static TGenerator Instance
        {
            get { return instance; }
        }
    }
}
