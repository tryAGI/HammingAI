#nullable enable

namespace HammingAI
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List all datasets<br/>
        /// Retrieves a list of all datasets in the workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.ListDatasetsResponse> ListDatasetsAsync(
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}