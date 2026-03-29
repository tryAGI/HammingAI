namespace HammingAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HammingAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HAMMING_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : Environment.GetEnvironmentVariable("HAMMINGAI_API_KEY") is { Length: > 0 } altKeyValue
                    ? altKeyValue
                    : throw new AssertInconclusiveException("HAMMING_API_KEY environment variable is not found.");

        var client = new HammingAIClient(apiKey);

        return client;
    }
}
