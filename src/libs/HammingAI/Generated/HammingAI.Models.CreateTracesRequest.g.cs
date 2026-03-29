
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTracesRequest
    {
        /// <summary>
        /// Array of traces to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public global::System.Collections.Generic.IList<global::HammingAI.ExperimentTrace>? Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTracesRequest" /> class.
        /// </summary>
        /// <param name="traces">
        /// Array of traces to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTracesRequest(
            global::System.Collections.Generic.IList<global::HammingAI.ExperimentTrace>? traces)
        {
            this.Traces = traces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTracesRequest" /> class.
        /// </summary>
        public CreateTracesRequest()
        {
        }
    }
}