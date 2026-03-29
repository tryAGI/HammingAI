
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemMetrics
    {
        /// <summary>
        /// Duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemMetrics" /> class.
        /// </summary>
        /// <param name="durationMs">
        /// Duration in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItemMetrics(
            int? durationMs)
        {
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemMetrics" /> class.
        /// </summary>
        public ExperimentItemMetrics()
        {
        }
    }
}