namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface ICity : IIdentity
    {
        string Name { get; }

        bool IsCapital { get; }

        int Population { get; }

        /// <summary>
        /// Area in square kms
        /// </summary>
        int TotalArea { get; }

        ICountry Country { get; }
    }
}
