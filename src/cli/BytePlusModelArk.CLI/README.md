# BytePlusModelArk.CLI

Command-line interface for the BytePlusModelArk SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global BytePlusModelArk.CLI --prerelease
```

## Usage

```bash
byte-plus-model-ark --help
byte-plus-model-ark images --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
byte-plus-model-ark completion bash > /usr/local/etc/bash_completion.d/byte-plus-model-ark
byte-plus-model-ark completion zsh  > _byte-plus-model-ark   # then put it on your zsh fpath
byte-plus-model-ark completion fish > ~/.config/fish/completions/byte-plus-model-ark.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.