using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast
{
    public class TemperatureReading : CachingSerializable, IIdentity
    {
        public int Id { get; set; }

        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int Temperature { get; set; }
        
        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int ReelFeel { get; set; }

        /// <summary>
        /// Dew point in Celsius
        /// </summary>
        public int DewPoint { get; set; }

        public TemperatureDescription Description { get; set; }
    }

    public enum TemperatureDescription
    {
        /// <summary>
        /// Temperature equal or lesser than 7 Celsius degrees
        /// </summary>
        VeryCold,
        /// <summary>
        /// Temperature between 8 - 12 Celsius degrees
        /// </summary>
        Cold,
        /// <summary>
        /// Temperature between 13 - 17 Celsius degrees
        /// </summary>
        Cool,
        /// <summary>
        /// Temperature between 18 - 22 Celsius degrees
        /// </summary>
        Mild,
        /// <summary>
        /// Temperature between 23 - 27 Celsius degrees
        /// </summary>
        Warm,
        /// <summary>
        /// Temperature between 28 - 32 Celsius degrees
        /// </summary>
        Hot,
        /// <summary>
        /// Temperature equals or greater than 33
        /// </summary>
        VeryHot
    }
}
