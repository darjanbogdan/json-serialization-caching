using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class BaseDataGenerator<T> where T : IIdentity
    {
        #region Fields

        private List<T> dataCollection;
        private int? collectionLength;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Used for manual generation
        /// </summary>
        public BaseDataGenerator()
            : this(null)
        {
        }

        /// <summary>
        /// Used for automatic generation
        /// </summary>
        /// <param name="collectionLength"></param>
        public BaseDataGenerator(int? collectionLength)
        {
            this.collectionLength = collectionLength;
            if (this.collectionLength.HasValue)
            {
                this.dataCollection = new List<T>(this.collectionLength.Value);
                GenerateDataAutomatic();
            }
            else
            {
                this.dataCollection = new List<T>();
                GenerateDataManual(this.dataCollection);
            }
        }

        #endregion Constructors

        #region Automatic Generation

        private void GenerateDataAutomatic()
        {
            for (int i = 0; i < collectionLength; i++)
            {
                this.dataCollection.Add(CreateDataObject(i));
            }
        }

        /// <summary>
        /// Used to create data object which will be added to the collection.
        /// Has to be implemented if automatic dynamic is used
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        protected virtual T CreateDataObject(int i)
        {
            return default(T);
        }

        #endregion Automatic Generation

        #region Manual Generation

        /// <summary>
        /// Used to manually populate data collection
        /// </summary>
        /// <param name="dataCollection"></param>
        protected virtual void GenerateDataManual(List<T> dataCollection)
        {
        }

        #endregion Manual Generation

        #region Methods

        public IEnumerable<T> GetAll()
        {
            return dataCollection;
        }

        public T GetItem(int id)
        {
            return dataCollection.FirstOrDefault(p => p.Id == id);
        }

        public T GetRandomItem()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return dataCollection.ElementAt(random.Next(this.dataCollection.Count));
        }

        #endregion Methods
    }
}
