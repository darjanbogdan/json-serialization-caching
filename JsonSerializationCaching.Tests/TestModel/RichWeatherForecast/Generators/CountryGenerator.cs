using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class CountryGenerator : SingletonDataGenerator<CountryGenerator, Country>
    {
        public override void PopulateCollection(int? collectionLength = null)
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
            this.DataCollection = countries;
        }
    }
}
