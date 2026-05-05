#nullable enable

namespace HammingAI
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create an experiment item<br/>
        /// Creates a new experiment item for a specific dataset item within an experiment.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateExperimentItemResponse> CreateExperimentItemAsync(
            string experimentId,

            global::HammingAI.CreateExperimentItemRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an experiment item<br/>
        /// Creates a new experiment item for a specific dataset item within an experiment.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse<global::HammingAI.CreateExperimentItemResponse>> CreateExperimentItemAsResponseAsync(
            string experimentId,

            global::HammingAI.CreateExperimentItemRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an experiment item<br/>
        /// Creates a new experiment item for a specific dataset item within an experiment.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="datasetItemId">
        /// ID of the dataset item.
        /// </param>
        /// <param name="output">
        /// Initial output (typically empty).
        /// </param>
        /// <param name="metrics">
        /// Initial metrics (typically empty).
        /// </param>
        /// <param name="sampleId">
        /// Sample index for multi-sample experiments.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateExperimentItemResponse> CreateExperimentItemAsync(
            string experimentId,
            string datasetItemId,
            object? output = default,
            object? metrics = default,
            int? sampleId = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}