using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class Country : CachingSerializable, ICountry
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Population { get; set; }

        /// <summary>
        /// Area in square kms
        /// </summary>
        public int TotalArea { get; set; }
    }
}
