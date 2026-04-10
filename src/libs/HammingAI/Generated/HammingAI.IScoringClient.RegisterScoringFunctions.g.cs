#nullable enable

namespace HammingAI
{
    public partial interface IScoringClient
    {
        /// <summary>
        /// Register custom scoring functions<br/>
        /// Registers custom scoring functions for use in experiments. Returns configurations with generated IDs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.RegisterScoringFunctionsResponse> RegisterScoringFunctionsAsync(

            global::HammingAI.RegisterScoringFunctionsRequest request,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register custom scoring functions<br/>
        /// Registers custom scoring functions for use in experiments. Returns configurations with generated IDs.
        /// </summary>
        /// <param name="scoring"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.RegisterScoringFunctionsResponse> RegisterScoringFunctionsAsync(
            global::System.Collections.Generic.IList<global::HammingAI.RegisterScoringFunctionsRequestScoringItem>? scoring = default,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}