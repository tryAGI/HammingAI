
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        public global::HammingAI.Experiment? Experiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentResponse" /> class.
        /// </summary>
        /// <param name="experiment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentResponse(
            global::HammingAI.Experiment? experiment)
        {
            this.Experiment = experiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentResponse" /> class.
        /// </summary>
        public CreateExperimentResponse()
        {
        }
    }
}