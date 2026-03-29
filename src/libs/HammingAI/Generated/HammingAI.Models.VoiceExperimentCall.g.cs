
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceExperimentCall
    {
        /// <summary>
        /// Call ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Scoring status for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_status")]
        public string? ScoringStatus { get; set; }

        /// <summary>
        /// Call transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// URL to the call recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_url")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// Call duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Additional call metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceExperimentCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Call ID.
        /// </param>
        /// <param name="scoringStatus">
        /// Scoring status for this call.
        /// </param>
        /// <param name="transcript">
        /// Call transcript.
        /// </param>
        /// <param name="recordingUrl">
        /// URL to the call recording.
        /// </param>
        /// <param name="durationMs">
        /// Call duration in milliseconds.
        /// </param>
        /// <param name="metadata">
        /// Additional call metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceExperimentCall(
            string? id,
            string? scoringStatus,
            string? transcript,
            string? recordingUrl,
            int? durationMs,
            object? metadata)
        {
            this.Id = id;
            this.ScoringStatus = scoringStatus;
            this.Transcript = transcript;
            this.RecordingUrl = recordingUrl;
            this.DurationMs = durationMs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceExperimentCall" /> class.
        /// </summary>
        public VoiceExperimentCall()
        {
        }
    }
}