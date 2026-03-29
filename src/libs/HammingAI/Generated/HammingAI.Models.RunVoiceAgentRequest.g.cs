
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunVoiceAgentRequest
    {
        /// <summary>
        /// Phone number to call for the voice agent test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

        /// <summary>
        /// Dataset ID containing test scenarios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunVoiceAgentRequest" /> class.
        /// </summary>
        /// <param name="toNumber">
        /// Phone number to call for the voice agent test.
        /// </param>
        /// <param name="datasetId">
        /// Dataset ID containing test scenarios.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunVoiceAgentRequest(
            string toNumber,
            string datasetId)
        {
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunVoiceAgentRequest" /> class.
        /// </summary>
        public RunVoiceAgentRequest()
        {
        }
    }
}