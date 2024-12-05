//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;


    internal class ResponseBodyDeserializer
    {

        public static T? Deserialize<T>(string json, NullValueHandling nullValueHandling=NullValueHandling.Ignore, MissingMemberHandling missingMemberHandling=MissingMemberHandling.Ignore)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings(){ NullValueHandling = nullValueHandling, MissingMemberHandling = missingMemberHandling, Converters = Utilities.GetJsonDeserializers(typeof(T))});
        }

        public sealed class MissingMemberException : Exception
        {
            public MissingMemberException() : base("Missing member.") { }
        }

        public sealed class DeserializationException : Exception
        {
            public DeserializationException(Type type) : base($"Could not deserialize into {type} type.") { }
        }

        public static T? DeserializeUndiscriminatedUnionMember<T>(string json)
        {
            try
            {
                return Deserialize<T>(json, missingMemberHandling: MissingMemberHandling.Error);
            }
            catch (Exception ex)
            {
                if (ex is Newtonsoft.Json.JsonSerializationException &&
                    ex.Source == "Newtonsoft.Json" &&
                    ex.Message.Contains("Could not find member"))
                {
                    throw new MissingMemberException();
                }
                else if (ex is Newtonsoft.Json.JsonReaderException ||
                         ex is Newtonsoft.Json.JsonSerializationException
                )
                {
                    throw new DeserializationException(typeof(T));
                }

                throw;
            }
        }

        public static object DeserializeUndiscriminatedUnionFallback(System.Type type, object obj, string propertyName, string json)
        {
            MethodInfo? method = typeof(ResponseBodyDeserializer).GetMethod("Deserialize");
            if (method != null)
            {
                MethodInfo generic = method!.MakeGenericMethod(type);
                var args = new object[] { json, NullValueHandling.Ignore, MissingMemberHandling.Ignore };
                var value = generic.Invoke(null, args);
                PropertyInfo? propertyInfo = obj.GetType().GetProperty(propertyName!);
                if (propertyInfo != null && value != null)
                {
                    propertyInfo!.SetValue(obj, value!);
                    return obj;
                }
            }

            throw new DeserializationException(type);
        }

        public static int MissingJsonProperties(System.Type type, string json)
        {
            int missing = 0;

            JObject jo = JObject.Parse(json);

            var jsonPropertyAttributes = type.GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(JsonPropertyAttribute)))
                .Select(prop => prop.GetCustomAttribute(typeof(JsonPropertyAttribute)) as JsonPropertyAttribute)
                .Where(attr => attr != null && attr!.PropertyName != null)
                .ToList();

            foreach (var attr in jsonPropertyAttributes)
            {
                string propertyName = attr!.PropertyName!;
                if (!jo.TryGetValue(propertyName, out var _value)){
                    missing++;
                }
            }

            return missing;
        }

        public static int CompareFallbackCandidates(System.Type typeA, System.Type typeB, string json)
        {
            var missingA = MissingJsonProperties(typeA, json);
            var missingB = MissingJsonProperties(typeB, json);

            if (missingA == missingB)
            {
                return typeB.GetProperties().Count().CompareTo(typeA.GetProperties().Count());
            }

            return missingA.CompareTo(missingB);
        }

    }
}