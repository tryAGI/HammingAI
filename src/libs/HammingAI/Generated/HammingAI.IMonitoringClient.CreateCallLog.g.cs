#nullable enable

namespace HammingAI
{
    public partial interface IMonitoringClient
    {
        /// <summary>
        /// Log a call for monitoring<br/>
        /// Submits a call recording and metadata for monitoring and evaluation. Hamming generates quality scores and insights from the call data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateCallLogAsync(

            global::HammingAI.CreateCallLogRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log a call for monitoring<br/>
        /// Submits a call recording and metadata for monitoring and evaluation. Hamming generates quality scores and insights from the call data.
        /// </summary>
        /// <param name="provider">
        /// Voice agent provider.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the call.
        /// </param>
        /// <param name="payload">
        /// Call payload data.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateCallLogAsync(
            string? provider = default,
            object? metadata = default,
            object? payload = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}