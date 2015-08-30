using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public abstract class DataFactory<T> where T : IIdentity
    {
        private int dataCollectionLength;
        protected int DataCollectionlength
        {
            get { return this.dataCollectionLength; }
        }

        private List<T> dataCollection;
        public IEnumerable<T> DataCollection
        {
            get { return this.dataCollection; }
        }

        public DataFactory(int collectionLength)
        {
            this.dataCollection = new List<T>();
            this.dataCollectionLength = collectionLength;
            Populate(dataCollection);
        }

        protected abstract void Populate(List<T> data);

        protected abstract T CreateItem(int id);

        public T GetItem(int id)
        {
            return dataCollection.FirstOrDefault(p => p.Id == id);
        }

        public T GetRandomItem()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int id = random.Next(this.dataCollection.Count);
            return dataCollection.FirstOrDefault(d => d.Id == id);
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
