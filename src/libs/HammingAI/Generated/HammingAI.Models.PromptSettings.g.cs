
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptSettings
    {
        /// <summary>
        /// Temperature for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Top P for nucleus sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Frequency penalty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyPenalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Presence penalty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presencePenalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptSettings" /> class.
        /// </summary>
        /// <param name="temperature">
        /// Temperature for generation.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens.
        /// </param>
        /// <param name="topP">
        /// Top P for nucleus sampling.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty.
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptSettings(
            double? temperature,
            int? maxTokens,
            double? topP,
            double? frequencyPenalty,
            double? presencePenalty)
        {
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.TopP = topP;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptSettings" /> class.
        /// </summary>
        public PromptSettings()
        {
        }
    }
}