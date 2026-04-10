#nullable enable

namespace HammingAI
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Update experiment status<br/>
        /// Updates the status of an experiment (e.g., to FINISHED or FAILED).
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateExperimentAsync(
            string experimentId,

            global::HammingAI.UpdateExperimentRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update experiment status<br/>
        /// Updates the status of an experiment (e.g., to FINISHED or FAILED).
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateExperimentAsync(
            string experimentId,
            global::HammingAI.ExperimentStatus? status = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}