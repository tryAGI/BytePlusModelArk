
#nullable enable

namespace BytePlusModelArk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public long? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::BytePlusModelArk.ImageData>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::BytePlusModelArk.Error? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="data"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponse(
            long? created,
            global::System.Collections.Generic.IList<global::BytePlusModelArk.ImageData>? data,
            global::BytePlusModelArk.Error? error)
        {
            this.Created = created;
            this.Data = data;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        public ImageGenerationResponse()
        {
        }
    }
}