using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast
{
    public class HumidityReading : CachingSerializable, IIdentity
    {
        public int Id { get; set; }

        /// <summary>
        /// Humidity in percentage
        /// </summary>
        public int Humidity { get; set; }

        public HumidityDescription Description { get; set; }
    }

    public enum HumidityDescription
    {
        /// <summary>
        /// 0 - 40 %
        /// </summary>
        VeryDry,
        /// <summary>
        /// 40 - 70 %
        /// </summary>
        Dry,
        /// <summary>
        /// 75 - 95 %
        /// </summary>
        Humid,
        /// <summary>
        /// 95 - 100 %
        /// </summary>
        VeryHumid
    }
}
