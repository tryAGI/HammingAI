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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.VoiceExperimentCallsResponse> GetVoiceExperimentCallsAsync(
            string voiceExperimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}