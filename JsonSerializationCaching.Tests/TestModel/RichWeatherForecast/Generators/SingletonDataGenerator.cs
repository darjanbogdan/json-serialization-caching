using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;

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
