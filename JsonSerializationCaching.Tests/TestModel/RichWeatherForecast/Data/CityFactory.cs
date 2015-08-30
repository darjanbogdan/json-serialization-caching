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

        public static CityFactory GetInstance()
        {
            if (instance == null)
                instance = new CityFactory();
            return instance;
        }

        protected override void Populate(List<City> data)
        {
            var countryFactory = CountryFactory.GetInstance();

            var cities = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Country = countryFactory.GetItem(1),
                    IsCapital = true,
                    Name = "Zagreb",
                    Population = 1200000,
                    TotalArea = 150
                },
                new City()
                {
                    Id = 2,
                    Country = countryFactory.GetItem(1),
                    IsCapital = false,
                    Name = "Osijek",
                    Population = 130000,
                    TotalArea = 90
                },
                new City()
                {
                    Id = 3,
                    Country = countryFactory.GetItem(1),
                    IsCapital = false,
                    Name = "Split",
                    Population = 300000,
                    TotalArea = 120
                },
                new City()
                {
                    Id = 2,
                    Country = countryFactory.GetItem(2),
                    IsCapital = true,
                    Name = "Amsterdam",
                    Population = 1600000,
                    TotalArea = 90
                },
                new City()
                {
                    Id = 2,
                    Country = countryFactory.GetItem(2),
                    IsCapital = false,
                    Name = "Rotterdam",
                    Population = 500000,
                    TotalArea = 150
                }
            };
            data.AddRange(cities);
        }
    }   
}
