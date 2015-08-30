﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Serialization
{
    public static class CachingSettings
    {
        public static JsonSerializerSettings Default { get; private set; }

        static CachingSettings()
        {
            Default = new JsonSerializerSettings();
            Default.Converters.Add(new StringEnumConverter());
        }

    }
}
