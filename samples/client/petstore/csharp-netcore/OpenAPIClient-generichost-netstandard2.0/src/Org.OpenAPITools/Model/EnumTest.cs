// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EnumTest
    /// </summary>
    public partial class EnumTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTest" /> class.
        /// </summary>
        /// <param name="enumInteger">enumInteger</param>
        /// <param name="enumIntegerOnly">enumIntegerOnly</param>
        /// <param name="enumNumber">enumNumber</param>
        /// <param name="enumString">enumString</param>
        /// <param name="enumStringRequired">enumStringRequired</param>
        /// <param name="outerEnumDefaultValue">outerEnumDefaultValue</param>
        /// <param name="outerEnumInteger">outerEnumInteger</param>
        /// <param name="outerEnumIntegerDefaultValue">outerEnumIntegerDefaultValue</param>
        /// <param name="outerEnum">outerEnum</param>
        [JsonConstructor]
        public EnumTest(EnumIntegerEnum enumInteger, EnumIntegerOnlyEnum enumIntegerOnly, EnumNumberEnum enumNumber, EnumStringEnum enumString, EnumStringRequiredEnum enumStringRequired, OuterEnumDefaultValue outerEnumDefaultValue, OuterEnumInteger outerEnumInteger, OuterEnumIntegerDefaultValue outerEnumIntegerDefaultValue, OuterEnum? outerEnum = default)
        {
            EnumInteger = enumInteger;
            EnumIntegerOnly = enumIntegerOnly;
            EnumNumber = enumNumber;
            EnumString = enumString;
            EnumStringRequired = enumStringRequired;
            OuterEnumDefaultValue = outerEnumDefaultValue;
            OuterEnumInteger = outerEnumInteger;
            OuterEnumIntegerDefaultValue = outerEnumIntegerDefaultValue;
            OuterEnum = outerEnum;
        }

        /// <summary>
        /// Defines EnumInteger
        /// </summary>
        public enum EnumIntegerEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            NUMBER_MINUS_1 = -1

        }

        /// <summary>
        /// Returns a EnumIntegerEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumIntegerEnum EnumIntegerEnumFromString(string value)
        {
            if (value == (1).ToString())
                return EnumIntegerEnum.NUMBER_1;

            if (value == (-1).ToString())
                return EnumIntegerEnum.NUMBER_MINUS_1;

            throw new NotImplementedException($"Could not convert value to type EnumIntegerEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int EnumIntegerEnumToJsonValue(EnumIntegerEnum value)
        {
            return (int) value;
        }

        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [JsonPropertyName("enum_integer")]
        public EnumIntegerEnum EnumInteger { get; set; }

        /// <summary>
        /// Defines EnumIntegerOnly
        /// </summary>
        public enum EnumIntegerOnlyEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_MINUS_2 for value: -2
            /// </summary>
            NUMBER_MINUS_2 = -2

        }

        /// <summary>
        /// Returns a EnumIntegerOnlyEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumIntegerOnlyEnum EnumIntegerOnlyEnumFromString(string value)
        {
            if (value == (2).ToString())
                return EnumIntegerOnlyEnum.NUMBER_2;

            if (value == (-2).ToString())
                return EnumIntegerOnlyEnum.NUMBER_MINUS_2;

            throw new NotImplementedException($"Could not convert value to type EnumIntegerOnlyEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int EnumIntegerOnlyEnumToJsonValue(EnumIntegerOnlyEnum value)
        {
            return (int) value;
        }

        /// <summary>
        /// Gets or Sets EnumIntegerOnly
        /// </summary>
        [JsonPropertyName("enum_integer_only")]
        public EnumIntegerOnlyEnum EnumIntegerOnly { get; set; }

        /// <summary>
        /// Defines EnumNumber
        /// </summary>
        public enum EnumNumberEnum
        {
            /// <summary>
            /// Enum NUMBER_1_DOT_1 for value: 1.1
            /// </summary>
            NUMBER_1_DOT_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1_DOT_2 for value: -1.2
            /// </summary>
            NUMBER_MINUS_1_DOT_2 = 2

        }

        /// <summary>
        /// Returns a EnumNumberEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumNumberEnum EnumNumberEnumFromString(string value)
        {
            if (value == "1.1")
                return EnumNumberEnum.NUMBER_1_DOT_1;

            if (value == "-1.2")
                return EnumNumberEnum.NUMBER_MINUS_1_DOT_2;

            throw new NotImplementedException($"Could not convert value to type EnumNumberEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double EnumNumberEnumToJsonValue(EnumNumberEnum value)
        {
            if (value == EnumNumberEnum.NUMBER_1_DOT_1)
                return 1.1;

            if (value == EnumNumberEnum.NUMBER_MINUS_1_DOT_2)
                return -1.2;

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [JsonPropertyName("enum_number")]
        public EnumNumberEnum EnumNumber { get; set; }

        /// <summary>
        /// Defines EnumString
        /// </summary>
        public enum EnumStringEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            Empty = 3

        }

        /// <summary>
        /// Returns a EnumStringEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumStringEnum EnumStringEnumFromString(string value)
        {
            if (value == "UPPER")
                return EnumStringEnum.UPPER;

            if (value == "lower")
                return EnumStringEnum.Lower;

            if (value == "")
                return EnumStringEnum.Empty;

            throw new NotImplementedException($"Could not convert value to type EnumStringEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EnumStringEnumToJsonValue(EnumStringEnum value)
        {
            if (value == EnumStringEnum.UPPER)
                return "UPPER";

            if (value == EnumStringEnum.Lower)
                return "lower";

            if (value == EnumStringEnum.Empty)
                return "";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [JsonPropertyName("enum_string")]
        public EnumStringEnum EnumString { get; set; }

        /// <summary>
        /// Defines EnumStringRequired
        /// </summary>
        public enum EnumStringRequiredEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            Empty = 3

        }

        /// <summary>
        /// Returns a EnumStringRequiredEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumStringRequiredEnum EnumStringRequiredEnumFromString(string value)
        {
            if (value == "UPPER")
                return EnumStringRequiredEnum.UPPER;

            if (value == "lower")
                return EnumStringRequiredEnum.Lower;

            if (value == "")
                return EnumStringRequiredEnum.Empty;

            throw new NotImplementedException($"Could not convert value to type EnumStringRequiredEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EnumStringRequiredEnumToJsonValue(EnumStringRequiredEnum value)
        {
            if (value == EnumStringRequiredEnum.UPPER)
                return "UPPER";

            if (value == EnumStringRequiredEnum.Lower)
                return "lower";

            if (value == EnumStringRequiredEnum.Empty)
                return "";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumStringRequired
        /// </summary>
        [JsonPropertyName("enum_string_required")]
        public EnumStringRequiredEnum EnumStringRequired { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnumDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumDefaultValue")]
        public OuterEnumDefaultValue OuterEnumDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnumInteger
        /// </summary>
        [JsonPropertyName("outerEnumInteger")]
        public OuterEnumInteger OuterEnumInteger { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnumIntegerDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumIntegerDefaultValue")]
        public OuterEnumIntegerDefaultValue OuterEnumIntegerDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnum
        /// </summary>
        [JsonPropertyName("outerEnum")]
        public OuterEnum? OuterEnum { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnumTest {\n");
            sb.Append("  EnumInteger: ").Append(EnumInteger).Append("\n");
            sb.Append("  EnumIntegerOnly: ").Append(EnumIntegerOnly).Append("\n");
            sb.Append("  EnumNumber: ").Append(EnumNumber).Append("\n");
            sb.Append("  EnumString: ").Append(EnumString).Append("\n");
            sb.Append("  EnumStringRequired: ").Append(EnumStringRequired).Append("\n");
            sb.Append("  OuterEnumDefaultValue: ").Append(OuterEnumDefaultValue).Append("\n");
            sb.Append("  OuterEnumInteger: ").Append(OuterEnumInteger).Append("\n");
            sb.Append("  OuterEnumIntegerDefaultValue: ").Append(OuterEnumIntegerDefaultValue).Append("\n");
            sb.Append("  OuterEnum: ").Append(OuterEnum).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }


    /// <summary>
    /// A Json converter for type EnumTest
    /// </summary>
    public class EnumTestJsonConverter : JsonConverter<EnumTest>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EnumTest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            EnumTest.EnumIntegerEnum enumInteger = default;
            EnumTest.EnumIntegerOnlyEnum enumIntegerOnly = default;
            EnumTest.EnumNumberEnum enumNumber = default;
            EnumTest.EnumStringEnum enumString = default;
            EnumTest.EnumStringRequiredEnum enumStringRequired = default;
            OuterEnumDefaultValue outerEnumDefaultValue = default;
            OuterEnumInteger outerEnumInteger = default;
            OuterEnumIntegerDefaultValue outerEnumIntegerDefaultValue = default;
            OuterEnum? outerEnum = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "enum_integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumInteger = (EnumTest.EnumIntegerEnum)utf8JsonReader.GetInt32();
                            break;
                        case "enum_integer_only":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumIntegerOnly = (EnumTest.EnumIntegerOnlyEnum)utf8JsonReader.GetInt32();
                            break;
                        case "enum_number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumNumber = (EnumTest.EnumNumberEnum)utf8JsonReader.GetInt32();
                            break;
                        case "enum_string":
                            string enumStringRawValue = utf8JsonReader.GetString();
                            enumString = EnumTest.EnumStringEnumFromString(enumStringRawValue);
                            break;
                        case "enum_string_required":
                            string enumStringRequiredRawValue = utf8JsonReader.GetString();
                            enumStringRequired = EnumTest.EnumStringRequiredEnumFromString(enumStringRequiredRawValue);
                            break;
                        case "outerEnumDefaultValue":
                            string outerEnumDefaultValueRawValue = utf8JsonReader.GetString();
                            outerEnumDefaultValue = OuterEnumDefaultValueConverter.FromString(outerEnumDefaultValueRawValue);
                            break;
                        case "outerEnumInteger":
                            string outerEnumIntegerRawValue = utf8JsonReader.GetString();
                            outerEnumInteger = OuterEnumIntegerConverter.FromString(outerEnumIntegerRawValue);
                            break;
                        case "outerEnumIntegerDefaultValue":
                            string outerEnumIntegerDefaultValueRawValue = utf8JsonReader.GetString();
                            outerEnumIntegerDefaultValue = OuterEnumIntegerDefaultValueConverter.FromString(outerEnumIntegerDefaultValueRawValue);
                            break;
                        case "outerEnum":
                            string outerEnumRawValue = utf8JsonReader.GetString();
                            outerEnum = OuterEnumConverter.FromStringOrDefault(outerEnumRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (enumString == null)
                throw new ArgumentNullException(nameof(enumString), "Property is required for class EnumTest.");

            if (enumStringRequired == null)
                throw new ArgumentNullException(nameof(enumStringRequired), "Property is required for class EnumTest.");

            if (enumInteger == null)
                throw new ArgumentNullException(nameof(enumInteger), "Property is required for class EnumTest.");

            if (enumIntegerOnly == null)
                throw new ArgumentNullException(nameof(enumIntegerOnly), "Property is required for class EnumTest.");

            if (enumNumber == null)
                throw new ArgumentNullException(nameof(enumNumber), "Property is required for class EnumTest.");

            if (outerEnumInteger == null)
                throw new ArgumentNullException(nameof(outerEnumInteger), "Property is required for class EnumTest.");

            if (outerEnumDefaultValue == null)
                throw new ArgumentNullException(nameof(outerEnumDefaultValue), "Property is required for class EnumTest.");

            if (outerEnumIntegerDefaultValue == null)
                throw new ArgumentNullException(nameof(outerEnumIntegerDefaultValue), "Property is required for class EnumTest.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return new EnumTest(enumInteger, enumIntegerOnly, enumNumber, enumString, enumStringRequired, outerEnumDefaultValue, outerEnumInteger, outerEnumIntegerDefaultValue, outerEnum);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EnumTest enumTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteNumber("enum_integer", EnumTest.EnumIntegerEnumToJsonValue(enumTest.EnumInteger));
            writer.WriteNumber("enum_integer_only", EnumTest.EnumIntegerOnlyEnumToJsonValue(enumTest.EnumIntegerOnly));
            writer.WriteNumber("enum_number", EnumTest.EnumNumberEnumToJsonValue(enumTest.EnumNumber));
            var enumStringRawValue = EnumTest.EnumStringEnumToJsonValue(enumTest.EnumString);
            if (enumStringRawValue != null)
                writer.WriteString("enum_string", enumStringRawValue);
            else
                writer.WriteNull("enum_string");
            var enumStringRequiredRawValue = EnumTest.EnumStringRequiredEnumToJsonValue(enumTest.EnumStringRequired);
            if (enumStringRequiredRawValue != null)
                writer.WriteString("enum_string_required", enumStringRequiredRawValue);
            else
                writer.WriteNull("enum_string_required");
            var outerEnumDefaultValueRawValue = OuterEnumDefaultValueConverter.ToJsonValue(enumTest.OuterEnumDefaultValue);
            if (outerEnumDefaultValueRawValue != null)
                writer.WriteString("outerEnumDefaultValue", outerEnumDefaultValueRawValue);
            else
                writer.WriteNull("outerEnumDefaultValue");
            var outerEnumIntegerRawValue = OuterEnumIntegerConverter.ToJsonValue(enumTest.OuterEnumInteger);
            if (outerEnumIntegerRawValue != null)
                writer.WriteNumber("outerEnumInteger", outerEnumIntegerRawValue);
            else
                writer.WriteNull("outerEnumInteger");
            var outerEnumIntegerDefaultValueRawValue = OuterEnumIntegerDefaultValueConverter.ToJsonValue(enumTest.OuterEnumIntegerDefaultValue);
            if (outerEnumIntegerDefaultValueRawValue != null)
                writer.WriteNumber("outerEnumIntegerDefaultValue", outerEnumIntegerDefaultValueRawValue);
            else
                writer.WriteNull("outerEnumIntegerDefaultValue");
            if (enumTest.OuterEnum == null)
                writer.WriteNull("outerEnum");
            var outerEnumRawValue = OuterEnumConverter.ToJsonValue(enumTest.OuterEnum.Value);
            if (outerEnumRawValue != null)
                writer.WriteString("outerEnum", outerEnumRawValue);
            else
                writer.WriteNull("outerEnum");

            writer.WriteEndObject();
        }
    }
}
