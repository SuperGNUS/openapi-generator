// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// MixedPropertiesAndAdditionalPropertiesClass
    /// </summary>
    public partial class MixedPropertiesAndAdditionalPropertiesClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedPropertiesAndAdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime</param>
        /// <param name="map">map</param>
        /// <param name="uuid">uuid</param>
        /// <param name="uuidWithPattern">uuidWithPattern</param>
        [JsonConstructor]
        public MixedPropertiesAndAdditionalPropertiesClass(DateTime dateTime, Dictionary<string, Animal> map, Guid uuid, Guid uuidWithPattern)
        {
            DateTime = dateTime;
            Map = map;
            Uuid = uuid;
            UuidWithPattern = uuidWithPattern;
        }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [JsonPropertyName("map")]
        public Dictionary<string, Animal> Map { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets UuidWithPattern
        /// </summary>
        [JsonPropertyName("uuid_with_pattern")]
        public Guid UuidWithPattern { get; set; }

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
            sb.Append("class MixedPropertiesAndAdditionalPropertiesClass {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  UuidWithPattern: ").Append(UuidWithPattern).Append("\n");
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
            // UuidWithPattern (Guid) pattern
            Regex regexUuidWithPattern = new Regex("[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}", RegexOptions.CultureInvariant);
            if (false == regexUuidWithPattern.Match(this.UuidWithPattern.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UuidWithPattern, must match a pattern of " + regexUuidWithPattern, new [] { "UuidWithPattern" });
            }

            yield break;
        }
    }


    /// <summary>
    /// A Json converter for type MixedPropertiesAndAdditionalPropertiesClass
    /// </summary>
    public class MixedPropertiesAndAdditionalPropertiesClassJsonConverter : JsonConverter<MixedPropertiesAndAdditionalPropertiesClass>
    {
        /// <summary>
        /// The format to use to serialize DateTime
        /// </summary>
        public static string DateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MixedPropertiesAndAdditionalPropertiesClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            DateTime dateTime = default;
            Dictionary<string, Animal> map = default;
            Guid uuid = default;
            Guid uuidWithPattern = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "dateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateTime = JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "map":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                map = JsonSerializer.Deserialize<Dictionary<string, Animal>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "uuid":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uuid = utf8JsonReader.GetGuid();
                            break;
                        case "uuid_with_pattern":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uuidWithPattern = utf8JsonReader.GetGuid();
                            break;
                        default:
                            break;
                    }
                }
            }

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (uuidWithPattern == null)
                throw new ArgumentNullException(nameof(uuidWithPattern), "Property is required for class MixedPropertiesAndAdditionalPropertiesClass.");

            if (uuid == null)
                throw new ArgumentNullException(nameof(uuid), "Property is required for class MixedPropertiesAndAdditionalPropertiesClass.");

            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime), "Property is required for class MixedPropertiesAndAdditionalPropertiesClass.");

            if (map == null)
                throw new ArgumentNullException(nameof(map), "Property is required for class MixedPropertiesAndAdditionalPropertiesClass.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return new MixedPropertiesAndAdditionalPropertiesClass(dateTime, map, uuid, uuidWithPattern);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedPropertiesAndAdditionalPropertiesClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MixedPropertiesAndAdditionalPropertiesClass mixedPropertiesAndAdditionalPropertiesClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("dateTime", mixedPropertiesAndAdditionalPropertiesClass.DateTime.ToString(DateTimeFormat));
            writer.WritePropertyName("map");
            JsonSerializer.Serialize(writer, mixedPropertiesAndAdditionalPropertiesClass.Map, jsonSerializerOptions);
            writer.WriteString("uuid", mixedPropertiesAndAdditionalPropertiesClass.Uuid);
            writer.WriteString("uuid_with_pattern", mixedPropertiesAndAdditionalPropertiesClass.UuidWithPattern);

            writer.WriteEndObject();
        }
    }
}
