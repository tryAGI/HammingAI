# CLAUDE.md -- HammingAI SDK

## Overview

Auto-generated C# SDK for [Hamming AI](https://hamming.ai/) -- enterprise voice agent testing, evaluation, and production monitoring platform for voice agents built on Vapi, RetellAI, Bland, LiveKit, and other providers.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Hamming AI documentation and official TypeScript/Python SDKs.

## Build & Test

```bash
dotnet build HammingAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new HammingAIClient(apiKey); // HAMMING_API_KEY env var
```

Base URL: `https://app.hamming.ai/api/rest`

## Key Files

- `src/libs/HammingAI/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Hamming AI)
- `src/libs/HammingAI/generate.sh` -- Runs autosdk on local spec (no download step)
- `src/libs/HammingAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/HammingAI/Extensions/HammingAIClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new HammingAIClient(apiKey);

// Datasets
client.Datasets.ListDatasetsAsync()
client.Datasets.GetDatasetAsync(datasetId)
client.Datasets.CreateDatasetAsync(request)

// Experiments
client.Experiments.CreateExperimentAsync(request)
client.Experiments.UpdateExperimentAsync(experimentId, request)
client.Experiments.CreateExperimentItemAsync(experimentId, request)
client.Experiments.UpdateExperimentItemAsync(experimentId, itemId, request)

// Voice Agent Testing
client.VoiceAgents.RunVoiceAgentAsync(agentId, toNumber, datasetId)
client.VoiceAgents.GetVoiceExperimentAsync(voiceExperimentId)
client.VoiceAgents.GetVoiceExperimentCallsAsync(voiceExperimentId)
client.VoiceAgents.CreateLiveKitRoomsAsync(request)

// Prompts
client.Prompts.ListPromptsAsync()
client.Prompts.GetPromptAsync(slug)

// Monitoring
client.Monitoring.CreateSessionAsync(request)
client.Monitoring.CreateCallLogAsync(request)

// Scoring
client.Scoring.RegisterScoringFunctionsAsync(request)

// Tracing
client.Tracing.CreateTracesAsync(request)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsRunVoiceAgentTestTool()` -- Start a voice agent test run with dataset scenarios
- `AsGetVoiceExperimentStatusTool()` -- Check voice experiment status (RUNNING/FINISHED/FAILED)
- `AsGetVoiceExperimentCallsTool()` -- Get call results with scoring, transcripts, recordings
- `AsListDatasetsTool()` -- List all datasets in the workspace

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Hamming AI is a testing/evaluation platform with no matching MEAI interface.

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from:
  - Official TypeScript SDK (`github.com/HammingHQ/evals-ts`)
  - Official Python SDK (`github.com/HammingHQ/evals-py`)
  - Hamming AI documentation (`docs.hamming.ai`)
- Base URL: `https://app.hamming.ai/api/rest`
- Voice agent testing follows an async pattern: POST starts experiment, GET polls status, GET retrieves calls
- LiveKit direct rooms endpoint for agent-to-agent WebRTC testing
- Call monitoring endpoint at `/v2/call-logs` for production call ingestion
