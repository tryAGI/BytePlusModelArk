#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BytePlusModelArk.CLI.Commands;

internal static partial class ImagesCreateImageGenerationCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Model ID, for example seedream-5-0-260128.",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"Output size such as 1K, 2K, or a model-supported resolution.",
    };

    private static Option<global::BytePlusModelArk.ImageGenerationRequestResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"",
    };

    private static Option<bool?> Watermark { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--watermark",
        description: @"");

    private static Option<string?> SequentialImageGeneration { get; } = new(
        name: @"--sequential-image-generation")
    {
        Description = @"Optional sequential image generation mode.",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"");

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"",
    };

    private static Option<global::BytePlusModelArk.OneOf<string, global::System.Collections.Generic.IList<string>>?> Image { get; } = new(
        name: @"--image")
    {
        Description = @"Reference image input accepted by supported image editing models.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::BytePlusModelArk.ImageGenerationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BytePlusModelArk.ImageGenerationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-image-generation", @"Create an image generation request.
Generates images with BytePlus ModelArk image models such as Seedream 4.x and Seedream 5.x.");
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(Size);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Watermark);
                        command.Options.Add(SequentialImageGeneration);
                        command.Options.Add(Stream);
                        command.Options.Add(Seed);
                        command.Options.Add(Image);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BytePlusModelArk.ImageGenerationRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BytePlusModelArk.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var size = CliRuntime.WasSpecified(parseResult, Size) ? parseResult.GetValue(Size) : __requestBase is not null ? __requestBase.Size : default;
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : __requestBase is not null ? __requestBase.ResponseFormat : default;
                        var watermark = CliRuntime.WasSpecified(parseResult, Watermark) ? parseResult.GetValue(Watermark) : __requestBase is not null ? __requestBase.Watermark : default;
                        var sequentialImageGeneration = CliRuntime.WasSpecified(parseResult, SequentialImageGeneration) ? parseResult.GetValue(SequentialImageGeneration) : __requestBase is not null ? __requestBase.SequentialImageGeneration : default;
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : __requestBase is not null ? __requestBase.Stream : default;
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : __requestBase is not null ? __requestBase.Seed : default;
                        var image = CliRuntime.WasSpecified(parseResult, Image) ? parseResult.GetValue(Image) : __requestBase is not null ? __requestBase.Image : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateImageGenerationAsync(
                                    model: model,
                                    prompt: prompt,
                                    size: size,
                                    responseFormat: responseFormat,
                                    watermark: watermark,
                                    sequentialImageGeneration: sequentialImageGeneration,
                                    stream: stream,
                                    seed: seed,
                                    image: image,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::BytePlusModelArk.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BytePlusModelArk.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}