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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.GetDatasetResponse> GetDatasetAsync(
            string datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}