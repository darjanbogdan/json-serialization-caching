using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace JsonSerializationCaching.Tests.TestModel.SimpleWeatherForecast
{
    public abstract class SeedFactory<T> where T : class, new()
    {
        private List<T> seedCollection;
        protected List<T> SeedCollection
        {
            get { return this.seedCollection; }
        }

        public SeedFactory(int collectionLength)
        {
            seedCollection = new List<T>();
            Seed(collectionLength);
        }

        protected abstract void Seed(int collectionLength);

        public T GeRandomItem()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return seedCollection.ElementAt(random.Next(seedCollection.Count));
        }

        public IEnumerable<T> GetCollection()
        {
            return this.seedCollection;
        }
    }
}
