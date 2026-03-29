
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Score
    {
        /// <summary>
        /// Numeric score value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Optional reason for the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class.
        /// </summary>
        /// <param name="value">
        /// Numeric score value.
        /// </param>
        /// <param name="reason">
        /// Optional reason for the score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Score(
            double? value,
            string? reason)
        {
            this.Value = value;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class.
        /// </summary>
        public Score()
        {
        }
    }
}