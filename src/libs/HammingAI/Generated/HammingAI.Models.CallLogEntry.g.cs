
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallLogEntry
    {
        /// <summary>
        /// Voice agent provider (e.g., retell, vapi, custom).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Metadata about the call (e.g., agent_name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Call payload data including call_id and recording_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallLogEntry" /> class.
        /// </summary>
        /// <param name="provider">
        /// Voice agent provider (e.g., retell, vapi, custom).
        /// </param>
        /// <param name="metadata">
        /// Metadata about the call (e.g., agent_name).
        /// </param>
        /// <param name="payload">
        /// Call payload data including call_id and recording_url.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallLogEntry(
            string? provider,
            object? metadata,
            object? payload)
        {
            this.Provider = provider;
            this.Metadata = metadata;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallLogEntry" /> class.
        /// </summary>
        public CallLogEntry()
        {
        }
    }
}