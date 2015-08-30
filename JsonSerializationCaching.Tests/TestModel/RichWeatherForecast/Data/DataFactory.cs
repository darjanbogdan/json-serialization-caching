using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public abstract class DataFactory<T> where T : IIdentity, new()
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

        protected abstract void Populate(List<T> data);

        /// <summary>
        /// When default = 0, default collection length will be used (depends on the implementation factory)
        /// </summary>
        /// <param name="collectionLength"></param>
        public void Initialize(int collectionLength = 0)
        {
            this.dataCollection = new List<T>();
            this.dataCollectionLength = collectionLength;
            Populate(this.dataCollection);
        }

        public virtual T CreateItem(int id)
        {
            return default(T);
        }
        
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
