
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCallLogRequest
    {
        /// <summary>
        /// Voice agent provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Metadata about the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Call payload data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallLogRequest" /> class.
        /// </summary>
        /// <param name="provider">
        /// Voice agent provider.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the call.
        /// </param>
        /// <param name="payload">
        /// Call payload data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCallLogRequest(
            string? provider,
            object? metadata,
            object? payload)
        {
            this.Provider = provider;
            this.Metadata = metadata;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallLogRequest" /> class.
        /// </summary>
        public CreateCallLogRequest()
        {
        }
    }
}