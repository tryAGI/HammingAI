#nullable enable

namespace HammingAI
{
    public partial interface IVoiceAgentsClient
    {
        /// <summary>
        /// Get voice experiment status<br/>
        /// Retrieves the current status of a voice experiment (e.g., RUNNING, FINISHED, FAILED).
        /// </summary>
        /// <param name="voiceExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HammingAI.VoiceExperiment> GetVoiceExperimentAsync(
            string voiceExperimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}