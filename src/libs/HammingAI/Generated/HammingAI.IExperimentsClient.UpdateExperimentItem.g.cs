#nullable enable

namespace HammingAI
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Update an experiment item<br/>
        /// Updates an experiment item with output, scores, and metrics after execution.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateExperimentItemAsync(
            string experimentId,
            string itemId,

            global::HammingAI.UpdateExperimentItemRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an experiment item<br/>
        /// Updates an experiment item with output, scores, and metrics after execution.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse> UpdateExperimentItemAsResponseAsync(
            string experimentId,
            string itemId,

            global::HammingAI.UpdateExperimentItemRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an experiment item<br/>
        /// Updates an experiment item with output, scores, and metrics after execution.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="itemId"></param>
        /// <param name="output">
        /// Output data from the experiment run.
        /// </param>
        /// <param name="scores">
        /// Scores keyed by scoring function name.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="failed">
        /// Whether the item execution failed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateExperimentItemAsync(
            string experimentId,
            string itemId,
            object? output = default,
            global::System.Collections.Generic.Dictionary<string, global::HammingAI.Score>? scores = default,
            global::HammingAI.ExperimentItemMetrics? metrics = default,
            bool? failed = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}