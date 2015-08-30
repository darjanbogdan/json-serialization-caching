using System;

namespace JsonSerializationCaching.Tests.TestModel.SimpleWeatherForecast
{
    public class CountrySeedFactory : SeedFactory<Country>
    {
        public CountrySeedFactory(int collectionLength) 
            : base (collectionLength)
        {
        }

        protected override void Seed(int collectionLength)
        {
            for (int i = 0; i < collectionLength; i++)
            {
                this.SeedCollection.Add(new Country()
                {
                    Id = i,
                    Name = Utils.GetRandomString(),
                    Population = Utils.GetRandomNumber(1200000000),
                    TotalAreaInSquareKilometers = Utils.GetRandomNumber(17000000)
                });
            }
        }

    }
}
