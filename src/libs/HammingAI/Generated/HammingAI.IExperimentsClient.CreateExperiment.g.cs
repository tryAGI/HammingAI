#nullable enable

namespace HammingAI
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create an experiment<br/>
        /// Creates a new experiment linked to a dataset with specified scoring configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateExperimentResponse> CreateExperimentAsync(

            global::HammingAI.CreateExperimentRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an experiment<br/>
        /// Creates a new experiment linked to a dataset with specified scoring configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse<global::HammingAI.CreateExperimentResponse>> CreateExperimentAsResponseAsync(

            global::HammingAI.CreateExperimentRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an experiment<br/>
        /// Creates a new experiment linked to a dataset with specified scoring configuration.
        /// </summary>
        /// <param name="name">
        /// Name of the experiment.
        /// </param>
        /// <param name="dataset">
        /// Dataset ID to run the experiment against.
        /// </param>
        /// <param name="status"></param>
        /// <param name="scoring">
        /// Array of scoring types to apply.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata.
        /// </param>
        /// <param name="sampling">
        /// Number of samples per dataset item (max 10).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateExperimentResponse> CreateExperimentAsync(
            string name,
            string dataset,
            global::HammingAI.ExperimentStatus status,
            global::System.Collections.Generic.IList<string>? scoring = default,
            object? metadata = default,
            int? sampling = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}