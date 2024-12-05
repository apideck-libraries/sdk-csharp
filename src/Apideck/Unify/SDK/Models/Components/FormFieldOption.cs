//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK.Models.Components
{
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class FormFieldOptionType
    {
        private FormFieldOptionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static FormFieldOptionType SimpleFormFieldOption { get { return new FormFieldOptionType("SimpleFormFieldOption"); } }
        
        public static FormFieldOptionType FormFieldOptionGroup { get { return new FormFieldOptionType("FormFieldOptionGroup"); } }
        
        public static FormFieldOptionType Null { get { return new FormFieldOptionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(FormFieldOptionType v) { return v.Value; }
        public static FormFieldOptionType FromString(string v) {
            switch(v) {
                case "SimpleFormFieldOption": return SimpleFormFieldOption;
                case "FormFieldOptionGroup": return FormFieldOptionGroup;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for FormFieldOptionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((FormFieldOptionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(FormFieldOption.FormFieldOptionConverter))]
    public class FormFieldOption {
        public FormFieldOption(FormFieldOptionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public SimpleFormFieldOption? SimpleFormFieldOption { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public FormFieldOptionGroup? FormFieldOptionGroup { get; set; }

        public FormFieldOptionType Type { get; set; }


        public static FormFieldOption CreateSimpleFormFieldOption(SimpleFormFieldOption simpleFormFieldOption) {
            FormFieldOptionType typ = FormFieldOptionType.SimpleFormFieldOption;

            FormFieldOption res = new FormFieldOption(typ);
            res.SimpleFormFieldOption = simpleFormFieldOption;
            return res;
        }

        public static FormFieldOption CreateFormFieldOptionGroup(FormFieldOptionGroup formFieldOptionGroup) {
            FormFieldOptionType typ = FormFieldOptionType.FormFieldOptionGroup;

            FormFieldOption res = new FormFieldOption(typ);
            res.FormFieldOptionGroup = formFieldOptionGroup;
            return res;
        }

        public static FormFieldOption CreateNull() {
            FormFieldOptionType typ = FormFieldOptionType.Null;
            return new FormFieldOption(typ);
        }

        public class FormFieldOptionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(FormFieldOption);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new FormFieldOption(FormFieldOptionType.SimpleFormFieldOption)
                    {
                        SimpleFormFieldOption = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SimpleFormFieldOption>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SimpleFormFieldOption), new FormFieldOption(FormFieldOptionType.SimpleFormFieldOption), "SimpleFormFieldOption"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new FormFieldOption(FormFieldOptionType.FormFieldOptionGroup)
                    {
                        FormFieldOptionGroup = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<FormFieldOptionGroup>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(FormFieldOptionGroup), new FormFieldOption(FormFieldOptionType.FormFieldOptionGroup), "FormFieldOptionGroup"));
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
                FormFieldOption res = (FormFieldOption)value;
                if (FormFieldOptionType.FromString(res.Type).Equals(FormFieldOptionType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.SimpleFormFieldOption != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SimpleFormFieldOption));
                    return;
                }
                if (res.FormFieldOptionGroup != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.FormFieldOptionGroup));
                    return;
                }

            }

        }

    }
}