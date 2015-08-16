using System;

namespace JsonSerializationCaching.Tests.TestModel.Seed
{
    class WeatherReadingSeedFactory : SeedFactory<WeatherReading>
    {
        public WeatherReadingSeedFactory(int collectionLength)
            : base(collectionLength)
        {
        }

        protected override void Seed(int collectionLength)
        {
            CitySeedFactory cityFactory = new CitySeedFactory(1000);

            for (int i = 0; i < collectionLength; i++)
            {
                this.SeedCollection.Add(new WeatherReading()
                {
                    Id = i,
                    City = cityFactory.GeRandomItem(),
                    Description = GetRandomString(),
                    TemperatureInCelsius = GetRandomNumber(50),
                    RainfallPercentage = GetRandomNumber(100),
                    SurfaceWindPercentage = GetRandomNumber(100),
                    ReadingDate = DateTime.UtcNow
                });
            }
        }
    }
}
