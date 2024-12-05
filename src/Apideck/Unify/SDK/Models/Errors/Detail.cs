//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK.Models.Errors
{
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class DetailType
    {
        private DetailType(string value) { Value = value; }

        public string Value { get; private set; }
        public static DetailType Str { get { return new DetailType("str"); } }
        
        public static DetailType MapOfAny { get { return new DetailType("mapOfAny"); } }
        
        public static DetailType Null { get { return new DetailType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(DetailType v) { return v.Value; }
        public static DetailType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "mapOfAny": return MapOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for DetailType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((DetailType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// Contains parameter or domain specific information related to the error and why it occurred.
    /// </summary>
    [JsonConverter(typeof(Detail.DetailConverter))]
    public class Detail {
        public Detail(DetailType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public Dictionary<string, object>? MapOfAny { get; set; }

        public DetailType Type { get; set; }


        public static Detail CreateStr(string str) {
            DetailType typ = DetailType.Str;

            Detail res = new Detail(typ);
            res.Str = str;
            return res;
        }

        public static Detail CreateMapOfAny(Dictionary<string, object> mapOfAny) {
            DetailType typ = DetailType.MapOfAny;

            Detail res = new Detail(typ);
            res.MapOfAny = mapOfAny;
            return res;
        }

        public static Detail CreateNull() {
            DetailType typ = DetailType.Null;
            return new Detail(typ);
        }

        public class DetailConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Detail);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                if (json[0] == '"' && json[^1] == '"'){
                    return new Detail(DetailType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    return new Detail(DetailType.MapOfAny)
                    {
                        MapOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<Dictionary<string, object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(Dictionary<string, object>), new Detail(DetailType.MapOfAny), "MapOfAny"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                Detail res = (Detail)value;
                if (DetailType.FromString(res.Type).Equals(DetailType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.MapOfAny != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfAny));
                    return;
                }

            }

        }

    }
}