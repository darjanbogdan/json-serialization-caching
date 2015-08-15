using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Newtonsoft.Json;
using JsonSerializationCaching.Serialization;
using System.IO;
using JsonSerializationCaching.Tests.TestModel;
using Moq;
using System.Collections.Generic;

namespace JsonSerializationCaching.Tests.Tests
{
    public class PerformanceTests
    {
        [Fact]
        public void JsonSerializationCaching_PerformanceTest()
        {
            JsonSerializer serializer = JsonSerializer.Create();
            serializer.ContractResolver = new CachingContractResolver();

            List<Country> countries = new List<Country>();
            var croatia = new Country() { Id = 1, Name = "Croatia", Population = 1231231, TotalAreaInSquareKilometers = 1235 };
            for (int i = 0; i < 100000000; i++)
            {
                countries.Add(croatia);
            }

            long totalElapsedTime = SerializationInMs(serializer, countries);

            //List<string> outputs = new List<string>();
            //foreach (var country in countries)
            //{
            //    using (StringWriter writer = new StringWriter())
            //    {
            //        serializer.Serialize(writer, croatia);
            //        outputs.Add(writer.ToString());
            //    }
            //}
        }

        private long SerializationInMs(JsonSerializer serializer, IEnumerable<Country> countries)
        {
            long totalElapsed = 0;
            Stopwatch watch = new Stopwatch();
            foreach (var country in countries)
            {
                watch.Reset();
                using (StringWriter writer = new StringWriter())
                {
                    watch.Start();
                    serializer.Serialize(writer, country);
                    watch.Stop();
                    totalElapsed += watch.ElapsedMilliseconds;
                }
            }
            return totalElapsed;
        }

        [Fact]
        public void JsonSerializationDefault_PerformanceTest()
        {

        }
    }
}
