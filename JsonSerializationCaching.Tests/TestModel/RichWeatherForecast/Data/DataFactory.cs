using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public abstract class DataFactory<T> where T : IIdentity
    {
        private List<T> dataCollection;
        public IEnumerable<T> DataCollection
        {
            get { return this.dataCollection; }
        }

        public DataFactory()
        {
            dataCollection = new List<T>();
            Populate(dataCollection);
        }

        protected abstract void Populate(List<T> data);

        public T GetItem(int id)
        {
            return dataCollection.Where(p => p.Id == id).FirstOrDefault();
        }

        public T GetRandomItem()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int id = random.Next(this.dataCollection.Count);
            return dataCollection.Where(d => d.Id == id).FirstOrDefault();
        }
    }
}
