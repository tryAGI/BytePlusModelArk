#nullable enable

namespace BytePlusModelArk
{
    public partial interface IBytePlusModelArkClient
    {
        /// <summary>
        /// Create an image generation request.<br/>
        /// Generates images with BytePlus ModelArk image models such as Seedream 4.x and Seedream 5.x.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BytePlusModelArk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BytePlusModelArk.ImageGenerationResponse> CreateImageGenerationAsync(

            global::BytePlusModelArk.ImageGenerationRequest request,
            global::BytePlusModelArk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an image generation request.<br/>
        /// Generates images with BytePlus ModelArk image models such as Seedream 4.x and Seedream 5.x.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BytePlusModelArk.ImageGenerationResponse> CreateImageGenerationAsync(
            string model,
            string prompt,
            string? size = default,
            global::BytePlusModelArk.ImageGenerationRequestResponseFormat? responseFormat = default,
            bool? watermark = default,
            string? sequentialImageGeneration = default,
            bool? stream = default,
            int? seed = default,
            global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.IList<string>>? image = default,
            global::BytePlusModelArk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}