#nullable enable

namespace HammingAI
{
    public partial interface IMonitoringClient
    {
        /// <summary>
        /// Create a monitoring session<br/>
        /// Creates a new monitoring session for tracking live production calls and interactions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateSessionResponse> CreateSessionAsync(

            global::HammingAI.CreateSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a monitoring session<br/>
        /// Creates a new monitoring session for tracking live production calls and interactions.
        /// </summary>
        /// <param name="metadata">
        /// Session metadata (e.g., environment).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.CreateSessionResponse> CreateSessionAsync(
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}