#nullable enable

namespace HammingAI
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a dataset<br/>
        /// Creates a new dataset with items containing input, output, and metadata.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateDatasetResponse> CreateDatasetAsync(

            global::HammingAI.CreateDatasetRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset<br/>
        /// Creates a new dataset with items containing input, output, and metadata.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse<global::HammingAI.CreateDatasetResponse>> CreateDatasetAsResponseAsync(

            global::HammingAI.CreateDatasetRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset<br/>
        /// Creates a new dataset with items containing input, output, and metadata.
        /// </summary>
        /// <param name="name">
        /// Name of the dataset.
        /// </param>
        /// <param name="description">
        /// Optional description.
        /// </param>
        /// <param name="items">
        /// Array of dataset item values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            global::System.Collections.Generic.IList<global::HammingAI.DatasetItemValue> items,
            string? description = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}