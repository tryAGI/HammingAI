#nullable enable

namespace HammingAI
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a dataset by ID<br/>
        /// Retrieves a dataset with all its items.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.GetDatasetResponse> GetDatasetAsync(
            string datasetId,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}