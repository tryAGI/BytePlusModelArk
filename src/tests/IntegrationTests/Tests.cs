namespace BytePlusModelArk.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BytePlusModelArkClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ARK_API_KEY") is { Length: > 0 } arkKeyValue
                ? arkKeyValue
                : Environment.GetEnvironmentVariable("BYTEPLUSMODELARK_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ARK_API_KEY or BYTEPLUSMODELARK_API_KEY environment variable is not found.");

        var client = new BytePlusModelArkClient(apiKey);
        
        return client;
    }
}
