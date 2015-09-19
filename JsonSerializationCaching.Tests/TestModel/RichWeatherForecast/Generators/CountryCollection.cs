using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators
{
    public class CountryCollection : BaseDataGenerator<ICountry>
    {
        public CountryCollection()
            : base()
        {
        }

        protected override void GenerateDataManual(List<ICountry> dataCollection)
        {
            var countryCollection = new List<ICountry>()
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

            dataCollection.AddRange(countryCollection);
        }
    }
}