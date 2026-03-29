#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace HammingAI;

/// <summary>
/// Extensions for using HammingAIClient as MEAI tools with any IChatClient.
/// </summary>
public static class HammingAIToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that runs a voice agent test,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Hamming AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsRunVoiceAgentTestTool(
        this HammingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string agentId, string toNumber, string datasetId, CancellationToken cancellationToken) =>
            {
                var response = await client.VoiceAgents.RunVoiceAgentAsync(
                    agentId: agentId,
                    toNumber: toNumber,
                    datasetId: datasetId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Voice experiment started. Experiment ID: {response.VoiceExperimentId}";
            },
            name: "RunVoiceAgentTest",
            description: "Starts a voice agent test run by making parallel calls using scenarios from a dataset. Requires an agent ID, phone number to call, and dataset ID. Returns a voice experiment ID for tracking status and results.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the status of a voice experiment,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Hamming AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetVoiceExperimentStatusTool(
        this HammingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string voiceExperimentId, CancellationToken cancellationToken) =>
            {
                var response = await client.VoiceAgents.GetVoiceExperimentAsync(
                    voiceExperimentId: voiceExperimentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Voice Experiment ID: {response.Id}, Status: {response.Status}";
            },
            name: "GetVoiceExperimentStatus",
            description: "Gets the current status of a voice experiment (e.g., RUNNING, FINISHED, FAILED). Use the voice experiment ID returned from RunVoiceAgentTest.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the call results from a voice experiment,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Hamming AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetVoiceExperimentCallsTool(
        this HammingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string voiceExperimentId, CancellationToken cancellationToken) =>
            {
                var response = await client.VoiceAgents.GetVoiceExperimentCallsAsync(
                    voiceExperimentId: voiceExperimentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCallResults(response);
            },
            name: "GetVoiceExperimentCalls",
            description: "Gets the list of calls from a voice experiment with their scoring status, transcripts, recordings, and durations. Use after the experiment has finished.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all datasets,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Hamming AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListDatasetsTool(
        this HammingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Datasets.ListDatasetsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatDatasetsList(response);
            },
            name: "ListDatasets",
            description: "Lists all available datasets in the Hamming workspace. Datasets contain test scenarios (input/output pairs) used for voice agent testing and experiments.");
    }

    private static string FormatCallResults(VoiceExperimentCallsResponse response)
    {
        var parts = new List<string>();

        if (response.Calls is null || response.Calls.Count == 0)
        {
            return "No calls found for this voice experiment.";
        }

        parts.Add($"Calls ({response.Calls.Count}):");

        foreach (var call in response.Calls)
        {
            var entry = $"- Call {call.Id}: scoring={call.ScoringStatus}";
            if (call.DurationMs is not null)
            {
                entry += $", duration={call.DurationMs}ms";
            }
            if (!string.IsNullOrWhiteSpace(call.Transcript))
            {
                var transcript = call.Transcript.Length > 200
                    ? call.Transcript[..200] + "..."
                    : call.Transcript;
                entry += $", transcript=\"{transcript}\"";
            }
            if (!string.IsNullOrWhiteSpace(call.RecordingUrl))
            {
                entry += $", recording={call.RecordingUrl}";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatDatasetsList(ListDatasetsResponse response)
    {
        var parts = new List<string>();

        if (response.Datasets is null || response.Datasets.Count == 0)
        {
            return "No datasets found.";
        }

        parts.Add($"Datasets ({response.Datasets.Count}):");

        foreach (var dataset in response.Datasets)
        {
            var entry = $"- {dataset.Id}: {dataset.Name}";
            if (!string.IsNullOrWhiteSpace(dataset.Description))
            {
                entry += $" ({dataset.Description})";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }
}
