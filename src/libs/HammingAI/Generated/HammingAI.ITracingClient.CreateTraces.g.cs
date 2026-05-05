#nullable enable

namespace HammingAI
{
    public partial interface ITracingClient
    {
        /// <summary>
        /// Create experiment traces<br/>
        /// Creates trace events for an experiment item, including LLM generations and retrieval operations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTracesAsync(

            global::HammingAI.CreateTracesRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment traces<br/>
        /// Creates trace events for an experiment item, including LLM generations and retrieval operations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse> CreateTracesAsResponseAsync(

            global::HammingAI.CreateTracesRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment traces<br/>
        /// Creates trace events for an experiment item, including LLM generations and retrieval operations.
        /// </summary>
        /// <param name="traces">
        /// Array of traces to create.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTracesAsync(
            global::System.Collections.Generic.IList<global::HammingAI.ExperimentTrace>? traces = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}