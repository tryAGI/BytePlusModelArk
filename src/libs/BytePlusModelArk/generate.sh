#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace BytePlusModelArk \
  --clientClassName BytePlusModelArkClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/BytePlusModelArk.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/BytePlusModelArk.CLI \
  --sdk-project ../../libs/BytePlusModelArk/BytePlusModelArk.csproj \
  --targetFramework net10.0 \
  --namespace BytePlusModelArk \
  --clientClassName BytePlusModelArkClient \
  --package-id BytePlusModelArk.CLI \
  --tool-command-name byte-plus-model-ark \
  --user-secrets-id BytePlusModelArk.CLI \
  --api-key-env-var BYTEPLUSMODELARK_API_KEY \
  --base-url-env-var BYTEPLUSMODELARK_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
