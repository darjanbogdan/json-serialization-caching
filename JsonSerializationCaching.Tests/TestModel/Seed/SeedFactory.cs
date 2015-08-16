using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace JsonSerializationCaching.Tests.TestModel.Seed
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

        protected string GetRandomString()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int length = random.Next(40);
            for (int i = 0; i < length; i++)
            {
                builder.Append((char)random.Next('a', 'z' + 1));
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(builder.ToString());
        }

        protected int GetRandomNumber(int maxValue)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(maxValue);
        }

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
