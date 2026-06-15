#nullable enable

using System.CommandLine;

namespace BytePlusModelArk.CLI.Commands;

internal static class ImagesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"images", @"Images endpoint commands.");
                         command.Subcommands.Add(ImagesCreateImageGenerationCommandApiCommand.Create());
        return command;
    }
}