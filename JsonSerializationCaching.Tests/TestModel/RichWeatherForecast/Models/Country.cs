using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
