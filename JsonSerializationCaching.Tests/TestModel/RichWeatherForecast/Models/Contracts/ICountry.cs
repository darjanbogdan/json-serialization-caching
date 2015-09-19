namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface ICountry : IIdentity
    {
        string Name { get; }

        int Population { get; }

        /// <summary>
        /// Area in square kms
        /// </summary>
        int TotalArea { get; }
    }
}
