# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The HammingAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Hamming's voice agent testing, experiment status tracking, call result retrieval, and dataset management.

## Installation

```bash
dotnet add package HammingAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsRunVoiceAgentTestTool()` | `RunVoiceAgentTest` | Start a voice agent test run with dataset scenarios |
| `AsGetVoiceExperimentStatusTool()` | `GetVoiceExperimentStatus` | Check voice experiment status (RUNNING/FINISHED/FAILED) |
| `AsGetVoiceExperimentCallsTool()` | `GetVoiceExperimentCalls` | Get call results with scoring, transcripts, and recordings |
| `AsListDatasetsTool()` | `ListDatasets` | List all datasets in the workspace |

## Usage

```csharp
using HammingAI;
using Microsoft.Extensions.AI;

var hammingClient = new HammingAIClient(
    apiKey: Environment.GetEnvironmentVariable("HAMMING_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        hammingClient.AsRunVoiceAgentTestTool(),
        hammingClient.AsGetVoiceExperimentStatusTool(),
        hammingClient.AsGetVoiceExperimentCallsTool(),
        hammingClient.AsListDatasetsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all available test datasets and show me their details."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
