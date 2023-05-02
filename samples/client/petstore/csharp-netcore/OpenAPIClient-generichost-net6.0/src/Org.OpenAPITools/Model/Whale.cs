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
    /// Whale
    /// </summary>
    public partial class Whale : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Whale" /> class.
        /// </summary>
        /// <param name="className">className</param>
        /// <param name="hasBaleen">hasBaleen</param>
        /// <param name="hasTeeth">hasTeeth</param>
        [JsonConstructor]
        public Whale(string className, bool hasBaleen, bool hasTeeth)
        {
            ClassName = className;
            HasBaleen = hasBaleen;
            HasTeeth = hasTeeth;
        }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets HasBaleen
        /// </summary>
        [JsonPropertyName("hasBaleen")]
        public bool HasBaleen { get; set; }

        /// <summary>
        /// Gets or Sets HasTeeth
        /// </summary>
        [JsonPropertyName("hasTeeth")]
        public bool HasTeeth { get; set; }

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
            sb.Append("class Whale {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  HasBaleen: ").Append(HasBaleen).Append("\n");
            sb.Append("  HasTeeth: ").Append(HasTeeth).Append("\n");
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
    /// A Json converter for type Whale
    /// </summary>
    public class WhaleJsonConverter : JsonConverter<Whale>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Whale Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string className = default;
            bool hasBaleen = default;
            bool hasTeeth = default;

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
                        case "className":
                            className = utf8JsonReader.GetString();
                            break;
                        case "hasBaleen":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                hasBaleen = utf8JsonReader.GetBoolean();
                            break;
                        case "hasTeeth":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                hasTeeth = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (hasBaleen == null)
                throw new ArgumentNullException(nameof(hasBaleen), "Property is required for class Whale.");

            if (hasTeeth == null)
                throw new ArgumentNullException(nameof(hasTeeth), "Property is required for class Whale.");

            if (className == null)
                throw new ArgumentNullException(nameof(className), "Property is required for class Whale.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return new Whale(className, hasBaleen, hasTeeth);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="whale"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Whale whale, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("className", whale.ClassName);
            writer.WriteBoolean("hasBaleen", whale.HasBaleen);
            writer.WriteBoolean("hasTeeth", whale.HasTeeth);

            writer.WriteEndObject();
        }
    }
}
