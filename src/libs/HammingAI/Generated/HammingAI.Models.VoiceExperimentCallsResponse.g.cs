
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceExperimentCallsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public global::System.Collections.Generic.IList<global::HammingAI.VoiceExperimentCall>? Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceExperimentCallsResponse" /> class.
        /// </summary>
        /// <param name="calls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceExperimentCallsResponse(
            global::System.Collections.Generic.IList<global::HammingAI.VoiceExperimentCall>? calls)
        {
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceExperimentCallsResponse" /> class.
        /// </summary>
        public VoiceExperimentCallsResponse()
        {
        }
    }
}