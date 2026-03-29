#nullable enable

namespace HammingAI
{
    public partial interface ITracingClient
    {
        /// <summary>
        /// Create experiment traces<br/>
        /// Creates trace events for an experiment item, including LLM generations and retrieval operations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTracesAsync(

            global::HammingAI.CreateTracesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment traces<br/>
        /// Creates trace events for an experiment item, including LLM generations and retrieval operations.
        /// </summary>
        /// <param name="traces">
        /// Array of traces to create.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTracesAsync(
            global::System.Collections.Generic.IList<global::HammingAI.ExperimentTrace>? traces = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}