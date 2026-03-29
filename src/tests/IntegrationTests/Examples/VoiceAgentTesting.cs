/*
order: 20
title: Voice Agent Testing
slug: voice-agent-testing

Shows how to run a voice agent test and retrieve experiment results.
*/

namespace HammingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task VoiceAgentTesting()
    {
        using var client = GetAuthenticatedClient();

        var agentId =
            Environment.GetEnvironmentVariable("HAMMING_AGENT_ID") is { Length: > 0 } agentValue
                ? agentValue
                : throw new AssertInconclusiveException("HAMMING_AGENT_ID environment variable is not found.");

        var datasetId =
            Environment.GetEnvironmentVariable("HAMMING_DATASET_ID") is { Length: > 0 } datasetValue
                ? datasetValue
                : throw new AssertInconclusiveException("HAMMING_DATASET_ID environment variable is not found.");

        var toNumber =
            Environment.GetEnvironmentVariable("HAMMING_TO_NUMBER") is { Length: > 0 } numberValue
                ? numberValue
                : throw new AssertInconclusiveException("HAMMING_TO_NUMBER environment variable is not found.");

        //// Start a voice agent test run with the specified dataset scenarios.
        var runResponse = await client.VoiceAgents.RunVoiceAgentAsync(
            agentId: agentId,
            toNumber: toNumber,
            datasetId: datasetId);

        runResponse.Should().NotBeNull();
        runResponse.VoiceExperimentId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Voice Experiment ID: {runResponse.VoiceExperimentId}");

        //// Check the status of the voice experiment.
        var statusResponse = await client.VoiceAgents.GetVoiceExperimentAsync(
            voiceExperimentId: runResponse.VoiceExperimentId!);

        statusResponse.Should().NotBeNull();
        Console.WriteLine($"Status: {statusResponse.Status}");

        //// Retrieve call results once the experiment finishes.
        var callsResponse = await client.VoiceAgents.GetVoiceExperimentCallsAsync(
            voiceExperimentId: runResponse.VoiceExperimentId!);

        callsResponse.Should().NotBeNull();
        callsResponse.Calls.Should().NotBeNull();
        Console.WriteLine($"Calls: {callsResponse.Calls!.Count}");

        foreach (var call in callsResponse.Calls)
        {
            Console.WriteLine($"- Call {call.Id}: scoring={call.ScoringStatus}, duration={call.DurationMs}ms");
        }
    }
}
