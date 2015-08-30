using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data
{
    public class CityFactory : DataFactory<City>
    {
        private static CityFactory instance;

        private CityFactory()
        {

        }

        public static CityFactory GetInstance(int collectionLength)
        {
            if (instance == null)
                instance = new CityFactory();
            return instance;
        }

        protected override void Populate(List<City> data)
        {
            var cities = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Country = null,
                    IsCapital = true,
                    Name = "Zagreb",
                    Population = 1200000,
                    TotalArea = 150
                },
                new City()
                {
                    Id = 2,
                    Country = null,
                    IsCapital = true,
                    Name = "Osijek",
                    Population = 130000,
                    TotalArea = 90
                }
            };
            data.AddRange(cities);
        }
    }   
}
