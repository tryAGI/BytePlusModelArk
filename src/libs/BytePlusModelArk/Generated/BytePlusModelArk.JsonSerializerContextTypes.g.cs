
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace BytePlusModelArk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.ImageGenerationRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.ImageGenerationRequestResponseFormat? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.IList<string>>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.ImageGenerationResponse? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::BytePlusModelArk.ImageData>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.ImageData? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.Error? Type11 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.List<string>>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::BytePlusModelArk.ImageData>? ListType2 { get; set; }
    }
}