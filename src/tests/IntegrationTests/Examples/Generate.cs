/*
order: 10
title: Generate Seedream image
slug: generate-seedream-image

Generate an image with a BytePlus ModelArk Seedream model.
*/

namespace BytePlusModelArk.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateSeedreamImage()
    {
        using var client = GetAuthenticatedClient();

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

        response.Data.Should().NotBeNullOrEmpty();
    }
}
