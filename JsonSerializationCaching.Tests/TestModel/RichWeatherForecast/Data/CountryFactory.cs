using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class CountryFactory : DataFactory<Country>
    {
        private static CountryFactory instance;

        private CountryFactory()
            : base(0)
        {

        }

        public static CountryFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new CountryFactory();
            return instance;
        }

        protected override Country CreateItem(int id)
        {
            return new Country() { Id = id };
        }

        protected override void Populate(List<Country> data)
        {
            var countries = new List<Country>()
            {
                new Country()
                {
                    Id = 1,
                    Name = "Croatia",
                    Population =  4290612,
                    TotalArea = 56594
                },
                new Country()
                {
                    Id = 2,
                    Name = "Netherlands",
                    Population  = 16919139,
                    TotalArea = 41543
                }
            };
            data.AddRange(countries);
        }
    }
}
