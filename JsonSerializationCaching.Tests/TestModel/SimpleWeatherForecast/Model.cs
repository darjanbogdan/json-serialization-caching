using JsonSerializationCaching.Serialization;
using System;

namespace JsonSerializationCaching.Tests.TestModel.SimpleWeatherForecast
{
    public class WeatherReading : CachingSerializable
    {
        public int Id { get; set; }
        
        public City City { get; set; }

        public string Description { get; set; }

        public int TemperatureInCelsius { get; set; }

        public int RainfallPercentage { get; set; }

        public int SurfaceWindPercentage { get; set; }

        public DateTime ReadingDate { get; set; }
    }

    public class City : CachingSerializable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCapital { get; set; }

        public Country Country { get; set; }

        public int Population { get; set; }

        public int TotalAreaInSquareKilometers { get; set; }
        
        public string[] ZipCodes { get; set; }

        public int[] AreaCodes { get; set; }

        public string WebSiteUrl { get; set; }

        public string FlagUrl { get; set; }
    }

    public class Country : CachingSerializable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public int TotalAreaInSquareKilometers { get; set; }
    }
}
