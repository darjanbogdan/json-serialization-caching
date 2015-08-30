using System;

namespace JsonSerializationCaching.Tests.TestModel.SimpleWeatherForecast
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
                    Description = Utils.GetRandomString(),
                    TemperatureInCelsius = Utils.GetRandomNumber(50),
                    RainfallPercentage = Utils.GetRandomNumber(100),
                    SurfaceWindPercentage = Utils.GetRandomNumber(100),
                    ReadingDate = DateTime.UtcNow
                });
            }
        }
    }
}
