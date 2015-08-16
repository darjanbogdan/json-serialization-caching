using System;

namespace JsonSerializationCaching.Tests.TestModel.Seed
{
    public class CitySeedFactory : SeedFactory<City>
    {
        public CitySeedFactory(int collectionLength)
            : base (collectionLength)
        {
        }

        protected override void Seed(int collectionLength)
        {
            CountrySeedFactory countryFactory = new CountrySeedFactory(100);
            
            for (int i = 0; i < collectionLength; i++)
            {
                this.SeedCollection.Add(new City()
                {
                    Id = i,
                    Name = GetRandomString(),
                    IsCapital = i % 2 == 0,
                    Country = countryFactory.GeRandomItem(),
                    Population = GetRandomNumber(50000000),
                    TotalAreaInSquareKilometers = GetRandomNumber(100000),
                    ZipCodes = new string[3] { GetRandomString(), GetRandomString(), GetRandomString() },
                    AreaCodes = new int[5] { GetRandomNumber(1000), GetRandomNumber(1000), GetRandomNumber(1000), GetRandomNumber(1000), GetRandomNumber(1000) },
                    WebSiteUrl = GetRandomString(),
                    FlagUrl = GetRandomString()
                });
            }
        }
    }
}
