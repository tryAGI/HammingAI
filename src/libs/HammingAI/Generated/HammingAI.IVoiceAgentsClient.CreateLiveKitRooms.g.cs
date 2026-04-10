#nullable enable

namespace HammingAI
{
    public partial interface IVoiceAgentsClient
    {
        /// <summary>
        /// Create LiveKit test rooms<br/>
        /// Creates LiveKit rooms for direct agent-to-agent voice testing. Returns room connection details including URLs and tokens for each dataset item.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateLiveKitRoomsResponse> CreateLiveKitRoomsAsync(

            global::HammingAI.CreateLiveKitRoomsRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create LiveKit test rooms<br/>
        /// Creates LiveKit rooms for direct agent-to-agent voice testing. Returns room connection details including URLs and tokens for each dataset item.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset ID for the test run.
        /// </param>
        /// <param name="datasetItemIds">
        /// Array of dataset item IDs to create rooms for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateLiveKitRoomsResponse> CreateLiveKitRoomsAsync(
            string datasetId,
            global::System.Collections.Generic.IList<string> datasetItemIds,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}