using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class CityGenerator : SingletonDataGenerator<CityGenerator, City>
    {
        public CityGenerator()
        {
            CountryGenerator.Instance.PopulateCollection();
        }

        public override void PopulateCollection(int? collectionLength = null)
        {
            this.DataCollection = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Country = CountryGenerator.Instance.GetItem(1),
                    IsCapital = true,
                    Name = "Zagreb",
                    Population = 1200000,
                    TotalArea = 150
                },
                new City()
                {
                    Id = 2,
                    Country = CountryGenerator.Instance.GetItem(1),
                    IsCapital = false,
                    Name = "Osijek",
                    Population = 130000,
                    TotalArea = 90
                },
                new City()
                {
                    Id = 3,
                    Country = CountryGenerator.Instance.GetItem(1),
                    IsCapital = false,
                    Name = "Split",
                    Population = 300000,
                    TotalArea = 120
                },
                new City()
                {
                    Id = 2,
                    Country = CountryGenerator.Instance.GetItem(2),
                    IsCapital = true,
                    Name = "Amsterdam",
                    Population = 1600000,
                    TotalArea = 90
                },
                new City()
                {
                    Id = 2,
                    Country = CountryGenerator.Instance.GetItem(2),
                    IsCapital = false,
                    Name = "Rotterdam",
                    Population = 500000,
                    TotalArea = 150
                }
            };
        }
    }   
}
