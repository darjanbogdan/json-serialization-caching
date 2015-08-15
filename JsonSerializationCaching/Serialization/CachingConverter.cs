using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Serialization
{
    public class CachingConverter : JsonConverter
    {
        #region Fields

        private JsonSerializer defaultSerializer;

        #endregion Fields

        #region Constructors

        public CachingConverter(JsonSerializer serializer)
        {
            this.defaultSerializer = serializer;
        }

        #endregion Constructors

        #region JsonConverter Methods

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var cacheValue = (CachingSerializable)value;
            cacheValue.Serialize(writer, this.defaultSerializer);
        }

        #endregion JsonConverter Methods
    }
}
