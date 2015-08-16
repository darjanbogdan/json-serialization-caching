using System;

namespace JsonSerializationCaching.Tests.TestModel.Seed
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
                    Name = GetRandomString(),
                    Population = GetRandomNumber(1200000000),
                    TotalAreaInSquareKilometers = GetRandomNumber(17000000)
                });
            }
        }

    }
}
