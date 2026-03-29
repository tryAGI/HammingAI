
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// Metadata about the call (e.g., agent_name).
    /// </summary>
    public sealed partial class CallLogEntryMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}