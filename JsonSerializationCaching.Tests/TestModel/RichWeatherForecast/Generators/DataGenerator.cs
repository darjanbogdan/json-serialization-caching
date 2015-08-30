using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public abstract class DataGenerator<T> where T : IIdentity
    {
        private List<T> dataCollection;
        public IEnumerable<T> DataCollection
        {
            get { return this.dataCollection; }
            protected set { this.dataCollection = value.ToList(); }
        }

        public abstract void PopulateCollection(int? collectionLength = null);

        public T GetItem(int id)
        {
            return dataCollection.FirstOrDefault(p => p.Id == id);
        }

        public T GetRandomItem()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return dataCollection.ElementAt(random.Next(this.dataCollection.Count));
        }

        public void RemoveItem(T item)
        {
            dataCollection.Remove(item);
        }

        public void InsertItem(T item)
        {
            dataCollection.Add(item);
        }
    }
}
