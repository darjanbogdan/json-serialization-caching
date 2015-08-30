﻿using JsonSerializationCaching.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Tests.TestModel.RichWeatherForecast
{
    public class WeatherStation : CachingSerializable, IIdentity
    {
        public int Id { get; set; }

        public Location Location { get; set; }

        public City City { get; set; }

        public IEnumerable<WeatherReading> WeatherReadings { get; set; }
    }
}
