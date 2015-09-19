namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface IPrecipitationReading : IIdentity
    {
        /// <summary>
        /// Rain in mm
        /// </summary>
        int Rain { get; }

        /// <summary>
        /// Snow in cm
        /// </summary>
        int Snow { get; }

        /// <summary>
        /// Ice in mm
        /// </summary>
        int Ice { get; }

        int HoursOfRain { get; }

        /// <summary>
        /// Hours of percipitation
        /// </summary>
        int HoursOverall { get; }
    }
}
