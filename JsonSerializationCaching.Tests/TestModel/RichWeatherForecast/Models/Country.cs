using JsonSerializationCaching.Serialization;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class Country : CachingSerializable, IIdentity
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
