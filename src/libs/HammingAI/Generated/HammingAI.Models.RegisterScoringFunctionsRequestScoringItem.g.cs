
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterScoringFunctionsRequestScoringItem
    {
        /// <summary>
        /// Name of the scoring function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Version of the scoring function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Scoring configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_config")]
        public object? ScoreConfig { get; set; }

        /// <summary>
        /// Execution configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_config")]
        public object? ExecutionConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterScoringFunctionsRequestScoringItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the scoring function.
        /// </param>
        /// <param name="version">
        /// Version of the scoring function.
        /// </param>
        /// <param name="scoreConfig">
        /// Scoring configuration.
        /// </param>
        /// <param name="executionConfig">
        /// Execution configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterScoringFunctionsRequestScoringItem(
            string? name,
            int? version,
            object? scoreConfig,
            object? executionConfig)
        {
            this.Name = name;
            this.Version = version;
            this.ScoreConfig = scoreConfig;
            this.ExecutionConfig = executionConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterScoringFunctionsRequestScoringItem" /> class.
        /// </summary>
        public RegisterScoringFunctionsRequestScoringItem()
        {
        }
    }
}