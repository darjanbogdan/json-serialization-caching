using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
