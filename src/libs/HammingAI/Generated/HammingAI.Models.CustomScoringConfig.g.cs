
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomScoringConfig
    {
        /// <summary>
        /// Unique identifier for the scoring config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Key name for the scoring function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomScoringConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the scoring config.
        /// </param>
        /// <param name="keyName">
        /// Key name for the scoring function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomScoringConfig(
            string? id,
            string? keyName)
        {
            this.Id = id;
            this.KeyName = keyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomScoringConfig" /> class.
        /// </summary>
        public CustomScoringConfig()
        {
        }
    }
}