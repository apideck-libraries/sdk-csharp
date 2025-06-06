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
    

    public class FormFieldOptionType
    {
        private FormFieldOptionType(string value) { Value = value; }

        public string Value { get; private set; }
        
        public static FormFieldOptionType Simple { get { return new FormFieldOptionType("simple"); } }
        public static FormFieldOptionType Group { get { return new FormFieldOptionType("group"); } }
        public static FormFieldOptionType Null { get { return new FormFieldOptionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(FormFieldOptionType v) { return v.Value; }
        public static FormFieldOptionType FromString(string v) {
            switch(v) {
                case "simple": return Simple;
                case "group": return Group;
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


        public static FormFieldOption CreateSimple(SimpleFormFieldOption simple) {
            FormFieldOptionType typ = FormFieldOptionType.Simple;
        
            string typStr = FormFieldOptionType.Simple.ToString();
            
            simple.OptionType = OptionTypeExtension.ToEnum(FormFieldOptionType.Simple.ToString());
            FormFieldOption res = new FormFieldOption(typ);
            res.SimpleFormFieldOption = simple;
            return res;
        }
        public static FormFieldOption CreateGroup(FormFieldOptionGroup groupT) {
            FormFieldOptionType typ = FormFieldOptionType.Group;
        
            string typStr = FormFieldOptionType.Group.ToString();
            
            groupT.OptionType = FormFieldOptionGroupOptionTypeExtension.ToEnum(FormFieldOptionType.Group.ToString());
            FormFieldOption res = new FormFieldOption(typ);
            res.FormFieldOptionGroup = groupT;
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
                JObject jo = JObject.Load(reader);
                string discriminator = jo.GetValue("option_type")?.ToString() ?? throw new ArgumentNullException("Could not find discriminator field.");
                if (discriminator == FormFieldOptionType.Simple.ToString())
                {
                    SimpleFormFieldOption? simpleFormFieldOption = ResponseBodyDeserializer.Deserialize<SimpleFormFieldOption>(jo.ToString());
                    return CreateSimple(simpleFormFieldOption!);
                }
                if (discriminator == FormFieldOptionType.Group.ToString())
                {
                    FormFieldOptionGroup? formFieldOptionGroup = ResponseBodyDeserializer.Deserialize<FormFieldOptionGroup>(jo.ToString());
                    return CreateGroup(formFieldOptionGroup!);
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