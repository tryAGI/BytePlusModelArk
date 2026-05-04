# Generate Seedream image

Generate an image with a BytePlus ModelArk Seedream model.

This example assumes `using BytePlusModelArk;` is in scope and `apiKey` contains your BytePlusModelArk API key.

```csharp
using var client = new BytePlusModelArkClient(apiKey);

var model =
    Environment.GetEnvironmentVariable("BYTEPLUSMODELARK_IMAGE_MODEL") is { Length: > 0 } modelValue
        ? modelValue
        : "seedream-5-0-260128";

var response = await client.CreateImageGenerationAsync(
    model: model,
    prompt: "A clean editorial product photo of a matte ceramic espresso cup.",
    size: "1K",
    responseFormat: ImageGenerationRequestResponseFormat.Url,
    watermark: false);
```