
#nullable enable

namespace BytePlusModelArk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        public string? B64Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revised_prompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="b64Json"></param>
        /// <param name="revisedPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageData(
            string? url,
            string? b64Json,
            string? revisedPrompt)
        {
            this.Url = url;
            this.B64Json = b64Json;
            this.RevisedPrompt = revisedPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        public ImageData()
        {
        }
    }
}