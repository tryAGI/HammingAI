
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExperimentItemRequest
    {
        /// <summary>
        /// Output data from the experiment run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Scores keyed by scoring function name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.Dictionary<string, global::HammingAI.Score>? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::HammingAI.ExperimentItemMetrics? Metrics { get; set; }

        /// <summary>
        /// Whether the item execution failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public bool? Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentItemRequest" /> class.
        /// </summary>
        /// <param name="output">
        /// Output data from the experiment run.
        /// </param>
        /// <param name="scores">
        /// Scores keyed by scoring function name.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="failed">
        /// Whether the item execution failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateExperimentItemRequest(
            object? output,
            global::System.Collections.Generic.Dictionary<string, global::HammingAI.Score>? scores,
            global::HammingAI.ExperimentItemMetrics? metrics,
            bool? failed)
        {
            this.Output = output;
            this.Scores = scores;
            this.Metrics = metrics;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentItemRequest" /> class.
        /// </summary>
        public UpdateExperimentItemRequest()
        {
        }
    }
}