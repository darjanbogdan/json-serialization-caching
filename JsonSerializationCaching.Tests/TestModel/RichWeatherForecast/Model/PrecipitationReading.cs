using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast
{
    public class PrecipitationReading : CachingSerializable, IIdentity
    {
        public int Id { get; set; }

        /// <summary>
        /// Rain in mm
        /// </summary>
        public int Rain { get; set; }

        /// <summary>
        /// Snow in cm
        /// </summary>
        public int Snow { get; set; }

        /// <summary>
        /// Ice in mm
        /// </summary>
        public int Ice { get; set; }

        public int HoursOfRain { get; set; }

        /// <summary>
        /// Hours of percipitation
        /// </summary>
        public int HoursOverall { get; set; }
    }
}
