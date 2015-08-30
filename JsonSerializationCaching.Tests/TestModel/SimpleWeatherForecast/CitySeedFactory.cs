using System;

namespace JsonSerializationCaching.Tests.TestModel.SimpleWeatherForecast
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
                    Name = Utils.GetRandomString(),
                    IsCapital = i % 2 == 0,
                    Country = countryFactory.GeRandomItem(),
                    Population = Utils.GetRandomNumber(50000000),
                    TotalAreaInSquareKilometers = Utils.GetRandomNumber(100000),
                    ZipCodes = new string[3] { Utils.GetRandomString(), Utils.GetRandomString(), Utils.GetRandomString() },
                    AreaCodes = new int[5] { Utils.GetRandomNumber(1000), Utils.GetRandomNumber(1000), Utils.GetRandomNumber(1000), Utils.GetRandomNumber(1000), Utils.GetRandomNumber(1000) },
                    WebSiteUrl = Utils.GetRandomString(),
                    FlagUrl = Utils.GetRandomString()
                });
            }
        }
    }
}
