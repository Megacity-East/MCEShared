using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
namespace MCELoader
{
    public static class JsonUtils
    {
        public class Vector3Converter : JsonConverter<Vector3>
        {
            public override void WriteJson(JsonWriter writer, Vector3 value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, new float[] { value.x, value.y, value.z });
            }

            public override Vector3 ReadJson(JsonReader reader, Type objectType, Vector3 existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                var v = serializer.Deserialize<float[]>(reader);
                return new Vector3(v[0], v[1], v[2]);
            }
        }
        public class QuaternionConverter : JsonConverter<Quaternion>
        {
            public override void WriteJson(JsonWriter writer, Quaternion value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, new float[] { value.x, value.y, value.z, value.w });
            }

            public override Quaternion ReadJson(JsonReader reader, Type objectType, Quaternion existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                var v = serializer.Deserialize<float[]>(reader);
                return new Quaternion(v[0], v[1], v[2], v[3]);
            }
        }

        public static JsonSerializerSettings SerializerSettings = new()
        {
            TypeNameHandling = TypeNameHandling.Auto,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new JsonConverter[] { new StringEnumConverter(), new Vector3Converter(), new QuaternionConverter() }

        };



    }
}
