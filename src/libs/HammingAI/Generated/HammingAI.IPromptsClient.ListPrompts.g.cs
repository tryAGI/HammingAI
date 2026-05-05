#nullable enable

namespace HammingAI
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List prompts<br/>
        /// Retrieves a list of all prompts, optionally filtered by label.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.ListPromptsResponse> ListPromptsAsync(
            string? label = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List prompts<br/>
        /// Retrieves a list of all prompts, optionally filtered by label.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse<global::HammingAI.ListPromptsResponse>> ListPromptsAsResponseAsync(
            string? label = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}