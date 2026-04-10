#nullable enable

namespace HammingAI
{
    public partial interface IVoiceAgentsClient
    {
        /// <summary>
        /// Get voice experiment calls<br/>
        /// Retrieves the list of calls made during a voice experiment with their scoring status, transcripts, and recordings.
        /// </summary>
        /// <param name="voiceExperimentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.VoiceExperimentCallsResponse> GetVoiceExperimentCallsAsync(
            string voiceExperimentId,
            global::HammingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}