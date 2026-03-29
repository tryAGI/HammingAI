
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterScoringFunctionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring")]
        public global::System.Collections.Generic.IList<global::HammingAI.CustomScoringConfig>? Scoring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterScoringFunctionsResponse" /> class.
        /// </summary>
        /// <param name="scoring"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterScoringFunctionsResponse(
            global::System.Collections.Generic.IList<global::HammingAI.CustomScoringConfig>? scoring)
        {
            this.Scoring = scoring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterScoringFunctionsResponse" /> class.
        /// </summary>
        public RegisterScoringFunctionsResponse()
        {
        }
    }
}