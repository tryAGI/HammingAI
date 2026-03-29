/*
order: 30
title: Prompts
slug: prompts

Shows how to list and retrieve prompts with their content.
*/

namespace HammingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Prompts()
    {
        using var client = GetAuthenticatedClient();

        //// List all prompts in the workspace.
        var promptsList = await client.Prompts.ListPromptsAsync();

        promptsList.Should().NotBeNull();
        promptsList.Prompts.Should().NotBeNull();
        Console.WriteLine($"Found {promptsList.Prompts!.Count} prompts.");

        //// Get a specific prompt by slug to see its content.
        if (promptsList.Prompts.Count > 0)
        {
            var slug = promptsList.Prompts[0].Slug!;
            var promptResponse = await client.Prompts.GetPromptAsync(slug: slug);

            promptResponse.Should().NotBeNull();
            promptResponse.Prompt.Should().NotBeNull();

            var promptValue = promptResponse.Prompt!.Value;
            Console.WriteLine($"Prompt slug: {promptValue.Value1?.Slug}");

            if (promptValue.Value2?.Content is not null)
            {
                Console.WriteLine($"Model: {promptValue.Value2.Content.LanguageModel}");
                Console.WriteLine($"Messages: {promptValue.Value2.Content.ChatMessages?.Count ?? 0}");
            }
        }
    }
}
