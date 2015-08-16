using JsonSerializationCaching.Serialization;
using JsonSerializationCaching.Tests.TestModel;
using JsonSerializationCaching.Tests.TestModel.Seed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Xunit;

namespace JsonSerializationCaching.Tests.Tests
{
    public class PerformanceTest
    {
        [Fact]
        public void PerformanceTest_JsonSerialization()
        {
            var weatherReadingFactory = new WeatherReadingSeedFactory(10000);
            var readings = weatherReadingFactory.GetCollection();
            
            //Default serialization
            JsonSerializer defaultSerializer = JsonSerializer.Create();
            var defaultMeasurement = TestSerializationPerformance(defaultSerializer, readings);

            //Caching serialization
            JsonSerializer cachingSerializer = JsonSerializer.Create();
            cachingSerializer.ContractResolver = new CachingContractResolver();
            var cachingMeasurement = TestSerializationPerformance(cachingSerializer, readings);
            string applicationDirectory = System.IO.Directory.GetCurrentDirectory();
            using (StreamWriter writer = new StreamWriter(String.Format("{0}\\{1}", applicationDirectory, "measurement.txt")))
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Default Serialization Measurement");
                foreach (var measurementUnit in defaultMeasurement)
                {
                    builder.AppendLine(String.Format("[{0}]: {1} ms", measurementUnit.Key, measurementUnit.Value));
                }
                builder.AppendLine();
                builder.AppendLine("Caching Serialization Measurement");
                foreach (var measurementUnit in cachingMeasurement)
                {
                    builder.AppendLine(String.Format("[{0}]: {1} ms", measurementUnit.Key, measurementUnit.Value));
                }

                writer.Write(builder.ToString());
            }
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
    }
}
