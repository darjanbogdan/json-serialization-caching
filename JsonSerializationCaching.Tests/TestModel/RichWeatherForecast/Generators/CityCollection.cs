using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class CityCollection : BaseDataGenerator<ICity>
    {
        private Lazy<CountryCollection> countryCollection = new Lazy<CountryCollection>(() => new CountryCollection());

        public CityCollection()
            : base()
        {
        }

        protected override void GenerateDataManual(List<ICity> dataCollection)
        {
            var cityCollection= new List<ICity>()
            {
                new City()
                {
                    Id = 1,
                    Country = this.countryCollection.Value.GetItem(1),
                    IsCapital = true,
                    Name = "Zagreb",
                    Population = 1200000,
                    TotalArea = 150
                },
                new City()
                {
                    Id = 2,
                    Country = this.countryCollection.Value.GetItem(1),
                    IsCapital = false,
                    Name = "Osijek",
                    Population = 130000,
                    TotalArea = 90
                },
                new City()
                {
                    Id = 3,
                    Country = this.countryCollection.Value.GetItem(1),
                    IsCapital = false,
                    Name = "Split",
                    Population = 300000,
                    TotalArea = 120
                },
                new City()
                {
                    Id = 2,
                    Country = this.countryCollection.Value.GetItem(2),
                    IsCapital = true,
                    Name = "Amsterdam",
                    Population = 1600000,
                    TotalArea = 90
                },
                new City()
                {
                    Id = 2,
                    Country = this.countryCollection.Value.GetItem(2),
                    IsCapital = false,
                    Name = "Rotterdam",
                    Population = 500000,
                    TotalArea = 150
                }
            };

            dataCollection.AddRange(cityCollection);
        }
    }   
}