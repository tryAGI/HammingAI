
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HammingAI.JsonConverters.DatasetWithItemsJsonConverter))]
        public global::HammingAI.DatasetWithItems? Dataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetResponse" /> class.
        /// </summary>
        /// <param name="dataset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetResponse(
            global::HammingAI.DatasetWithItems? dataset)
        {
            this.Dataset = dataset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetResponse" /> class.
        /// </summary>
        public CreateDatasetResponse()
        {
        }
    }
}