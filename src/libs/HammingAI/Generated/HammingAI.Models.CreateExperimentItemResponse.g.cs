
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentItemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::HammingAI.ExperimentItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentItemResponse" /> class.
        /// </summary>
        /// <param name="item"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentItemResponse(
            global::HammingAI.ExperimentItem? item)
        {
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentItemResponse" /> class.
        /// </summary>
        public CreateExperimentItemResponse()
        {
        }
    }
}