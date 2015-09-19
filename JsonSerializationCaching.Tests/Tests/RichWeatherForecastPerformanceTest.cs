using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Factories;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Generators;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models;
using JsonSerializationCaching.Tests.TestModel.RichWeatherForecast.Models.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xunit;

namespace JsonSerializationCaching.Tests.Tests
{
    public class RichWeatherForcastPerformanceTest
    {
        [Fact]
        public void PerformanceTest_RichWeatherForcesat_JsonSerialization()
        {
            WeatherStationCollection weatherStationsForDefault = new WeatherStationCollection(1000);
            WeatherStationCollection weatherStationsForCaching = new WeatherStationCollection(1000);

            //Default serialization
            JsonSerializer defaultSerializer = JsonSerializer.Create(CachingSettings.Default);
            //TestSerializationPerformance(defaultSerializer, weatherDefaultStations.DataCollection);
            this.StartMeasurement("Default Serialization", weatherStationsForDefault.GetAll(), defaultSerializer);
            
            //Caching serialization
            JsonSerializer cachingSerializer = JsonSerializer.Create(CachingSettings.Default);
            cachingSerializer.ContractResolver = new CachingContractResolver();
            //TestSerializationPerformance(cachingSerializer, weatherCachingStations.DataCollection);
            this.StartMeasurement("Cached Serialization", weatherStationsForCaching.GetAll(), cachingSerializer);
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

        private void StartMeasurement(string measurementTitle, IEnumerable<IWeatherStation> weatherStations, JsonSerializer serializer)
        {
            var weatherReadingFactory = WeatherReadingFactory.GetInstance();

            //Simulation: Every 2.5 seconds 1 weather station refresh (total of 20 refresh).
            //All weather stations will receive either completely new weather reading or updated existing weather reading (e.g. correction of existing reading)
            Dictionary<int, Measurement> testResults = new Dictionary<int, Measurement>();
            for (int i = 0; i < 20; i++)
            {
                Task.Delay(2500).ContinueWith(t =>
                {
                    Random rand = new Random();
                    foreach (var weatherStation in weatherStations)
                    {
                        //Insert or update five reading per weather station
                        for (int j = 0; j < 5; j++)
                        {
                            UpdateWeatherStation(weatherStation, weatherReadingFactory.CreateFakeItem(rand.Next(100)));
                        }
                    }

                    using (StringWriter writer = new StringWriter())
                    {
                        Stopwatch watch = new Stopwatch();
                        watch.Start();
                        serializer.Serialize(writer, weatherStations);
                        watch.Stop();
                        testResults.Add(i, new Measurement(watch.Elapsed.TotalMilliseconds, weatherStations.Sum(w => w.WeatherReadings.Count)));
                    }

                }).Wait();
            }

            this.LogMeasurement(measurementTitle, weatherStations.Count(), testResults);
        }

        private void UpdateWeatherStation(IWeatherStation weatherStation, WeatherReading newWeatherReading)
        {
            var weatherReading = weatherStation.WeatherReadings.SingleOrDefault(wr => wr.Id == newWeatherReading.Id);
            if (weatherReading != null)
            {
                //Remove existing weather reading, due to its immutability -> specified by business logic (contracts)
                weatherStation.WeatherReadings.RemoveAll(wr => wr.Id == weatherReading.Id);
            }
            //Insert new reading, or insert updated weather reading (older reading was removed)
            weatherStation.WeatherReadings.Add(newWeatherReading);
        }

        private void LogMeasurement(string measurementTitle, int weatherStationsNumber, Dictionary<int, Measurement> measurement)
        {
            string applicationDirectory = Directory.GetCurrentDirectory();
            using (TextWriter writer = new StreamWriter(String.Format("{0}\\{1}", applicationDirectory, "Rich weather forecast measurement.txt"), true))
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine(String.Format("{0} {1}:", DateTime.Now.ToString(), measurementTitle));
                builder.AppendLine(String.Format("Weather Stations: {0}", weatherStationsNumber.ToString()));
                foreach (var measurementUnit in measurement)
                {
                    builder.AppendLine(String.Format("[{0}]: {1} weather readings in {2} ms", measurementUnit.Key + 1, measurementUnit.Value.WeatherReadingsNumber, measurementUnit.Value.SerializationDuration));
                }
                builder.AppendLine();
                writer.Write(builder.ToString());
            }
        }

        private class Measurement
        {
            public double SerializationDuration { get; set; }

            public int WeatherReadingsNumber { get; set; }

            public Measurement(double serializationDuration, int weatherReadingsNumber)
            {
                this.SerializationDuration = serializationDuration;
                this.WeatherReadingsNumber = weatherReadingsNumber;
            }
        }
    }
}
