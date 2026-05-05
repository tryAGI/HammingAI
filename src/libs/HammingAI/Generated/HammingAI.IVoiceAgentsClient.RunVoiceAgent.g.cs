#nullable enable

namespace HammingAI
{
    public partial interface IVoiceAgentsClient
    {
        /// <summary>
        /// Run voice agent test<br/>
        /// Initiates a voice agent test run by making parallel calls using the specified dataset scenarios. Returns a voice experiment ID that can be used to track status and results.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.RunVoiceAgentResponse> RunVoiceAgentAsync(
            string agentId,

            global::HammingAI.RunVoiceAgentRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run voice agent test<br/>
        /// Initiates a voice agent test run by making parallel calls using the specified dataset scenarios. Returns a voice experiment ID that can be used to track status and results.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.AutoSDKHttpResponse<global::HammingAI.RunVoiceAgentResponse>> RunVoiceAgentAsResponseAsync(
            string agentId,

            global::HammingAI.RunVoiceAgentRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run voice agent test<br/>
        /// Initiates a voice agent test run by making parallel calls using the specified dataset scenarios. Returns a voice experiment ID that can be used to track status and results.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toNumber">
        /// Phone number to call for the voice agent test.
        /// </param>
        /// <param name="datasetId">
        /// Dataset ID containing test scenarios.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.RunVoiceAgentResponse> RunVoiceAgentAsync(
            string agentId,
            string toNumber,
            string datasetId,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}