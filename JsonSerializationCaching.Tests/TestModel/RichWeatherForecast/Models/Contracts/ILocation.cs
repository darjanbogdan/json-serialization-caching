namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts
{
    public interface ILocation
    {
        ICoordinate Latitude { get; }
        ICoordinate Longitude { get; }
    }

    public interface ICoordinate
    {
        int Degrees { get; }
        int Minutes { get; }
        int Seconds { get; }
        double Decimal { get; }
    }
}
