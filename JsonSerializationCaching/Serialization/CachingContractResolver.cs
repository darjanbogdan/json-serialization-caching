using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace JsonSerializationCaching.Serialization
{
    public class CachingContractResolver : DefaultContractResolver
    {

        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract contract = base.CreateContract(objectType);

            if (typeof(CachingSerializable).IsAssignableFrom(objectType))
            {
                var serializer = JsonSerializer.Create(); //Create plain serializer with default contract resolver and converters
                contract.Converter = new CachingConverter(serializer);
            }

            return contract;
        }

    }
}
