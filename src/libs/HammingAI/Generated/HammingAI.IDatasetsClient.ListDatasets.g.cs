#nullable enable

namespace HammingAI
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List all datasets<br/>
        /// Retrieves a list of all datasets in the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.ListDatasetsResponse> ListDatasetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}