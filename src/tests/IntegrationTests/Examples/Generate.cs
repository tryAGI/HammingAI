/*
order: 10
title: Getting Started
slug: getting-started

Shows how to create a client and list datasets.
*/

namespace HammingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Generate()
    {
        using var client = GetAuthenticatedClient();

        //// List all datasets in the workspace.
        var response = await client.Datasets.ListDatasetsAsync();

        response.Should().NotBeNull();
        response.Datasets.Should().NotBeNull();
        Console.WriteLine($"Found {response.Datasets!.Count} datasets.");

        foreach (var dataset in response.Datasets)
        {
            Console.WriteLine($"- {dataset.Id}: {dataset.Name}");
        }
    }
}
