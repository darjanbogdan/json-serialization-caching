using JsonSerializationCaching.Serialization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models
{
    public class WindReading : CachingSerializable, IIdentity
    {
        public int Id { get; set; }

        /// <summary>
        /// Speed in KM/h
        /// </summary>
        public int Speed { get; set; }

        public int BeaufortNumber { get; set; }

        /// <summary>
        /// Gust in KM/h
        /// </summary>
        public int Gust { get; set; }

        public WindDirection Direction { get; set; }

        public WindDescription Description { get; set; }
    }

    public enum WindDirection
    {
        North,
        NorthEast,
        NorthNorthEast,
        NortWest,
        NorthNorthWest,
        East,
        EastNorthEast,
        EastSouthEast,
        South,
        SouthEast,
        SouthSouthEast,
        SouthWest,
        SoutSouthWest,
        West,
        WestSouthWest,
        WestNorthWest
    }

    public enum WindDescription
    {
        /// <summary>
        /// Wind speed lesser than 2 (km/h)
        /// </summary>
        Calm,
        /// <summary>
        /// Wind speed between 2 - 12 (km/h)
        /// </summary>
        Light,
        /// <summary>
        /// Wind speed between 13 - 30 (km/h)
        /// </summary>
        Moderate,
        /// <summary>
        /// Wind speed between 31 - 40 (km/h)
        /// </summary>
        Fresh,
        /// <summary>
        /// Wind speed between 41 - 62 (km/h)
        /// </summary>
        Strong,
        /// <summary>
        /// Wind speed between 63 - 87 (km/h)
        /// </summary>
        Gale,
        /// <summary>
        /// Wind speed between 88 - 117 (km/h)
        /// </summary>
        Storm,
        /// <summary>
        /// Wind speed equals or greater than 118 (km/h)
        /// </summary>
        Hurricane
    }
}
