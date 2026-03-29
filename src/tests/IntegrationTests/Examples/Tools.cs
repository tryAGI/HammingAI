/*
order: 40
title: AIFunction Tools
slug: tools

Shows how to use HammingAI as MEAI AIFunction tools with any IChatClient.
*/

namespace HammingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AIFunctionTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient.
        var runTestTool = client.AsRunVoiceAgentTestTool();
        var getStatusTool = client.AsGetVoiceExperimentStatusTool();
        var getCallsTool = client.AsGetVoiceExperimentCallsTool();
        var listDatasetsTool = client.AsListDatasetsTool();

        runTestTool.Should().NotBeNull();
        runTestTool.Name.Should().Be("RunVoiceAgentTest");

        getStatusTool.Should().NotBeNull();
        getStatusTool.Name.Should().Be("GetVoiceExperimentStatus");

        getCallsTool.Should().NotBeNull();
        getCallsTool.Name.Should().Be("GetVoiceExperimentCalls");

        listDatasetsTool.Should().NotBeNull();
        listDatasetsTool.Name.Should().Be("ListDatasets");

        //// Pass these tools to any IChatClient via ChatOptions.Tools.
        Console.WriteLine($"Available tools: {runTestTool.Name}, {getStatusTool.Name}, {getCallsTool.Name}, {listDatasetsTool.Name}");
    }
}
