using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JsonSerializationCaching.Tests.Tests
{
    public class RichWeatherForcastPerformanceTest
    {
        [Fact]
        public void PerformanceTest_RichWeatherForcesat_JsonSerialization()
        {
            var weatherDefaultStations = WeatherStationFactory.GetInstance(20);
            var weatherCachedStations = WeatherStationFactory.GetInstance(20);

            //Default serialization
            JsonSerializer defaultSerializer = JsonSerializer.Create(CachingSettings.Default);
            var defaultMeasurement = TestSerializationPerformance(defaultSerializer, weatherDefaultStations.DataCollection);
            this.LogMeasurement("Default Measurement", defaultMeasurement);
            //Caching serialization
            JsonSerializer cachingSerializer = JsonSerializer.Create(CachingSettings.Default);
            cachingSerializer.ContractResolver = new CachingContractResolver();
            var cachingMeasurement = TestSerializationPerformance(cachingSerializer, weatherCachedStations.DataCollection);
            this.LogMeasurement("Caching Measurement", cachingMeasurement);
        }

        private Dictionary<int, double> TestSerializationPerformance(JsonSerializer serializer, IEnumerable<WeatherStation> weatherStations)
        {
            Dictionary<int, double> testOverview = new Dictionary<int, double>();
            Stopwatch watch = new Stopwatch();
            using (StringWriter writer = new StringWriter())
            {
                for (int i = 0; i < 20; i++)
                {
                    watch.Start();
                    serializer.Serialize(writer, weatherStations);
                    watch.Stop();
                    testOverview.Add(i, watch.Elapsed.TotalMilliseconds);
                    watch.Reset();
                }

            }
            return testOverview;
        }

        private void MeasurementStart(IEnumerable<WeatherStation> weatherStations)
        {
            Task.Delay(5000).ContinueWith(t => 
            {
                Random rand = new Random();
                foreach (var weatherStation in weatherStations)
                {
                    ReadingUpdate(weatherStation, rand.Next(1500));
                }
            });
        }

        private void ReadingUpdate(WeatherStation weatherStation, int weatherReadingId)
        {
            var weatherReading = weatherStation.WeatherReadings.FirstOrDefault(wr => wr.Id == weatherReadingId);
            if (weatherReading != null) //Perform Update
            {
                weatherStation.WeatherReadings.RemoveAll(wr => wr.Id == weatherReading.Id);
                weatherStation.WeatherReadings.Add(new WeatherReading()
                {
                    Id = weatherReadingId,
                    
                });
            }
            else //Perform Insert
            { }
        }

        private void LogMeasurement(string measurementTitle, Dictionary<int, double> measurement)
        {
            string applicationDirectory = Directory.GetCurrentDirectory();
            using (TextWriter writer = new StreamWriter(String.Format("{0}\\{1}", applicationDirectory, "Rich weather forecast measurement.txt"), true))
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine(String.Format("{0} {1}:", DateTime.Now.ToString(), measurementTitle));
                foreach (var measurementUnit in measurement)
                {
                    builder.AppendLine(String.Format("[{0}]: {1} ms", measurementUnit.Key + 1, measurementUnit.Value));
                }
                builder.AppendLine();
                writer.Write(builder.ToString());
            }
        }
    }
}
