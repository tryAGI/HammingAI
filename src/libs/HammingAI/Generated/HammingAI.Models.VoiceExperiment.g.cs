
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceExperiment
    {
        /// <summary>
        /// Unique identifier for the voice experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Status of the voice experiment (e.g., RUNNING, FINISHED, FAILED).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceExperiment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the voice experiment.
        /// </param>
        /// <param name="status">
        /// Status of the voice experiment (e.g., RUNNING, FINISHED, FAILED).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceExperiment(
            string? id,
            string? status)
        {
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceExperiment" /> class.
        /// </summary>
        public VoiceExperiment()
        {
        }
    }
}