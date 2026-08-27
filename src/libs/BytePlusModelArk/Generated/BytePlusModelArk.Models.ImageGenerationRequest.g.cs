
#nullable enable

namespace BytePlusModelArk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Model ID, for example seedream-5-0-260128.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Output size such as 1K, 2K, or a model-supported resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BytePlusModelArk.JsonConverters.ImageGenerationRequestResponseFormatJsonConverter))]
        public global::BytePlusModelArk.ImageGenerationRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Optional sequential image generation mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequential_image_generation")]
        public string? SequentialImageGeneration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Reference image input accepted by supported image editing models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BytePlusModelArk.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.IList<string>>? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID, for example seedream-5-0-260128.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="size">
        /// Output size such as 1K, 2K, or a model-supported resolution.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="watermark"></param>
        /// <param name="sequentialImageGeneration">
        /// Optional sequential image generation mode.
        /// </param>
        /// <param name="stream"></param>
        /// <param name="seed"></param>
        /// <param name="image">
        /// Reference image input accepted by supported image editing models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            string model,
            string prompt,
            string? size,
            global::BytePlusModelArk.ImageGenerationRequestResponseFormat? responseFormat,
            bool? watermark,
            string? sequentialImageGeneration,
            bool? stream,
            int? seed,
            global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.IList<string>>? image)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Size = size;
            this.ResponseFormat = responseFormat;
            this.Watermark = watermark;
            this.SequentialImageGeneration = sequentialImageGeneration;
            this.Stream = stream;
            this.Seed = seed;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }

    }
}