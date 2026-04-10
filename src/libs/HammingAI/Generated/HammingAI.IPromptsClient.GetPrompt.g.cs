#nullable enable

namespace HammingAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get a prompt by slug<br/>
        /// Retrieves a prompt with its content including chat messages, model settings, and tools.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="label"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.GetPromptResponse> GetPromptAsync(
            string slug,
            string? label = default,
            string? version = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}