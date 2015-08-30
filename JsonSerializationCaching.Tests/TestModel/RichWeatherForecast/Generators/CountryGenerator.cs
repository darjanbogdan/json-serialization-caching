using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using System.Collections.Generic;

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
