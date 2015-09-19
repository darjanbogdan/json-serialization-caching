using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class City : CachingSerializable, ICity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCapital { get; set; }

        public int Population { get; set; }

        /// <summary>
        /// Area in square kms
        /// </summary>
        public int TotalArea { get; set; }

        public ICountry Country { get; set; }
    }
}
