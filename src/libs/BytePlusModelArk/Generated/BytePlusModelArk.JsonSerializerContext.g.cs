
#nullable enable

namespace BytePlusModelArk
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::BytePlusModelArk.JsonConverters.ImageGenerationRequestResponseFormatJsonConverter),

            typeof(global::BytePlusModelArk.JsonConverters.ImageGenerationRequestResponseFormatNullableJsonConverter),

            typeof(global::BytePlusModelArk.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::BytePlusModelArk.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.ImageGenerationRequestResponseFormat), TypeInfoPropertyName = "ImageGenerationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.ImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BytePlusModelArk.ImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.ImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BytePlusModelArk.ImageData>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}