
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunVoiceAgentResponse
    {
        /// <summary>
        /// ID of the created voice experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_experiment_id")]
        public string? VoiceExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunVoiceAgentResponse" /> class.
        /// </summary>
        /// <param name="voiceExperimentId">
        /// ID of the created voice experiment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunVoiceAgentResponse(
            string? voiceExperimentId)
        {
            this.VoiceExperimentId = voiceExperimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunVoiceAgentResponse" /> class.
        /// </summary>
        public RunVoiceAgentResponse()
        {
        }
    }
}