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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateDatasetResponse> CreateDatasetAsync(

            global::HammingAI.CreateDatasetRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            global::System.Collections.Generic.IList<global::HammingAI.DatasetItemValue> items,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}