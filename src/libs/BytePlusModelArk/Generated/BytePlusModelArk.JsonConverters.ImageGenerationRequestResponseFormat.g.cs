#nullable enable

namespace BytePlusModelArk.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageGenerationRequestResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BytePlusModelArk.ImageGenerationRequestResponseFormat>
    {
        /// <inheritdoc />
        public override global::BytePlusModelArk.ImageGenerationRequestResponseFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::BytePlusModelArk.ImageGenerationRequestResponseFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BytePlusModelArk.ImageGenerationRequestResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BytePlusModelArk.ImageGenerationRequestResponseFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BytePlusModelArk.ImageGenerationRequestResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BytePlusModelArk.ImageGenerationRequestResponseFormatExtensions.ToValueString(value));
        }
    }
}
