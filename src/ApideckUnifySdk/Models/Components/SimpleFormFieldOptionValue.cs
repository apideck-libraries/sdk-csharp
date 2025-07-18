//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk.Models.Components
{
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class SimpleFormFieldOptionValueType
    {
        private SimpleFormFieldOptionValueType(string value) { Value = value; }

        public string Value { get; private set; }
        public static SimpleFormFieldOptionValueType Str { get { return new SimpleFormFieldOptionValueType("str"); } }
        
        public static SimpleFormFieldOptionValueType Integer { get { return new SimpleFormFieldOptionValueType("integer"); } }
        
        public static SimpleFormFieldOptionValueType Number { get { return new SimpleFormFieldOptionValueType("number"); } }
        
        public static SimpleFormFieldOptionValueType Boolean { get { return new SimpleFormFieldOptionValueType("boolean"); } }
        
        public static SimpleFormFieldOptionValueType ArrayOfValue5 { get { return new SimpleFormFieldOptionValueType("arrayOfValue5"); } }
        
        public static SimpleFormFieldOptionValueType Null { get { return new SimpleFormFieldOptionValueType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(SimpleFormFieldOptionValueType v) { return v.Value; }
        public static SimpleFormFieldOptionValueType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "integer": return Integer;
                case "number": return Number;
                case "boolean": return Boolean;
                case "arrayOfValue5": return ArrayOfValue5;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for SimpleFormFieldOptionValueType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((SimpleFormFieldOptionValueType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(SimpleFormFieldOptionValue.SimpleFormFieldOptionValueConverter))]
    public class SimpleFormFieldOptionValue {
        public SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public long? Integer { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<Value5>? ArrayOfValue5 { get; set; }

        public SimpleFormFieldOptionValueType Type { get; set; }


        public static SimpleFormFieldOptionValue CreateStr(string str) {
            SimpleFormFieldOptionValueType typ = SimpleFormFieldOptionValueType.Str;

            SimpleFormFieldOptionValue res = new SimpleFormFieldOptionValue(typ);
            res.Str = str;
            return res;
        }

        public static SimpleFormFieldOptionValue CreateInteger(long integer) {
            SimpleFormFieldOptionValueType typ = SimpleFormFieldOptionValueType.Integer;

            SimpleFormFieldOptionValue res = new SimpleFormFieldOptionValue(typ);
            res.Integer = integer;
            return res;
        }

        public static SimpleFormFieldOptionValue CreateNumber(double number) {
            SimpleFormFieldOptionValueType typ = SimpleFormFieldOptionValueType.Number;

            SimpleFormFieldOptionValue res = new SimpleFormFieldOptionValue(typ);
            res.Number = number;
            return res;
        }

        public static SimpleFormFieldOptionValue CreateBoolean(bool boolean) {
            SimpleFormFieldOptionValueType typ = SimpleFormFieldOptionValueType.Boolean;

            SimpleFormFieldOptionValue res = new SimpleFormFieldOptionValue(typ);
            res.Boolean = boolean;
            return res;
        }

        public static SimpleFormFieldOptionValue CreateArrayOfValue5(List<Value5> arrayOfValue5) {
            SimpleFormFieldOptionValueType typ = SimpleFormFieldOptionValueType.ArrayOfValue5;

            SimpleFormFieldOptionValue res = new SimpleFormFieldOptionValue(typ);
            res.ArrayOfValue5 = arrayOfValue5;
            return res;
        }

        public static SimpleFormFieldOptionValue CreateNull() {
            SimpleFormFieldOptionValueType typ = SimpleFormFieldOptionValueType.Null;
            return new SimpleFormFieldOptionValue(typ);
        }

        public class SimpleFormFieldOptionValueConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(SimpleFormFieldOptionValue);

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
                    return new SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToInt64(json);
                    return new SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType.Integer)
                    {
                        Integer = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType.Number)
                    {
                        Number = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    var converted = Convert.ToBoolean(json);
                    return new SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType.Boolean)
                    {
                        Boolean = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    return new SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType.ArrayOfValue5)
                    {
                        ArrayOfValue5 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<Value5>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<Value5>), new SimpleFormFieldOptionValue(SimpleFormFieldOptionValueType.ArrayOfValue5), "ArrayOfValue5"));
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
                SimpleFormFieldOptionValue res = (SimpleFormFieldOptionValue)value;
                if (SimpleFormFieldOptionValueType.FromString(res.Type).Equals(SimpleFormFieldOptionValueType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.Integer != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Integer));
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }
                if (res.ArrayOfValue5 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfValue5));
                    return;
                }

            }

        }

    }
}