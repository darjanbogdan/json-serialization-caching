using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Enums
{
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

    public enum CloudType
    {
        Cirrocumulus,
        Altocumulus,
        Cumulonimbus,
        Cumulus,
        Cirrus,
        Cirrostratus,
        Altostratus,
        Nimbostratus,
        Stratocumulus,
        Stratus,
        None
    }
}
