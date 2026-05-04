
#nullable enable

namespace BytePlusModelArk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        B64Json,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestResponseFormat value)
        {
            return value switch
            {
                ImageGenerationRequestResponseFormat.B64Json => "b64_json",
                ImageGenerationRequestResponseFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "b64_json" => ImageGenerationRequestResponseFormat.B64Json,
                "url" => ImageGenerationRequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}