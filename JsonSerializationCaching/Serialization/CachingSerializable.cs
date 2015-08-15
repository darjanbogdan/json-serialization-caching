using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationCaching.Serialization
{
    public abstract class CachingSerializable
    {
        #region Fields

        private string serializedObject;
        private Action<JsonWriter, JsonSerializer> GetSerializedObject;

        #endregion Fields

        #region Constructors

        public CachingSerializable()
        {
            GetSerializedObject = SerializeInit;
        }

        #endregion Constructors

        #region Methods

        public void Serialize(JsonWriter writer, JsonSerializer serializer)
        {
            GetSerializedObject(writer, serializer);
        }

        private void SerializeInit(JsonWriter writer, JsonSerializer serializer)
        {
            if (serializedObject == null)
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, this);
                    serializedObject = stringWriter.ToString();
                }
            }

            GetSerializedObject = (wr, sr) =>
            {
                wr.WriteRawValue(serializedObject);
            };

            GetSerializedObject(writer, serializer);
        }

        #endregion
    }
}
