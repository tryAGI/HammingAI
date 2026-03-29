
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// Call payload data including call_id and recording_url.
    /// </summary>
    public sealed partial class CallLogEntryPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}