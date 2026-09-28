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

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.