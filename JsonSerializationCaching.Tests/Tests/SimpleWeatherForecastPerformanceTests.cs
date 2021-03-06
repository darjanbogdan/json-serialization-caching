﻿using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel.SimpleWeatherForecast;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Xunit;

namespace JsonSerializationCaching.Tests.Tests
{
    public class SimpleWeatherForcastPerformanceTest
    {
        [Fact]
        public void PerformanceTest_SimpleWeatherForecast_JsonSerialization()
        {
            var weatherReadingFactory = new WeatherReadingSeedFactory(10000);
            var readings = weatherReadingFactory.GetCollection();
            
            //Default serialization
            JsonSerializer defaultSerializer = JsonSerializer.Create(CachingSettings.Default);
            var defaultMeasurement = TestSerializationPerformance(defaultSerializer, readings);
            this.LogMeasurement("Default Measurement", defaultMeasurement);

            //Caching serialization
            JsonSerializer cachingSerializer = JsonSerializer.Create(CachingSettings.Default);
            cachingSerializer.ContractResolver = new CachingContractResolver();
            var cachingMeasurement = TestSerializationPerformance(cachingSerializer, readings);
            this.LogMeasurement("Caching Measurement", cachingMeasurement);
        }

        private Dictionary<int, double> TestSerializationPerformance(JsonSerializer serializer, IEnumerable<WeatherReading> readings)
        {
            Dictionary<int, double> testOverview = new Dictionary<int, double>();
            Stopwatch watch = new Stopwatch();
            using (StringWriter writer = new StringWriter())
            {
                for (int i = 0; i < 20; i++)
                {
                    watch.Start();
                    serializer.Serialize(writer, readings);
                    watch.Stop();
                    testOverview.Add(i, watch.Elapsed.TotalMilliseconds);
                    watch.Reset();
                }
                
            }
            return testOverview;
        }

        private void LogMeasurement(string measurementTitle, Dictionary<int, double> measurement)
        {
            string applicationDirectory = Directory.GetCurrentDirectory();
            using (TextWriter writer = new StreamWriter(String.Format("{0}\\{1}", applicationDirectory, "Simple weather forecast measurement.txt"), true))
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
