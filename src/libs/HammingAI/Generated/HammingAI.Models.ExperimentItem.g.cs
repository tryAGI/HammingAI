
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItem
    {
        /// <summary>
        /// Unique identifier for the experiment item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// ID of the parent experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// ID of the corresponding dataset item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemId")]
        public string? DatasetItemId { get; set; }

        /// <summary>
        /// Output data from the experiment run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::HammingAI.ExperimentItemMetrics? Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HammingAI.JsonConverters.ExperimentItemStatusJsonConverter))]
        public global::HammingAI.ExperimentItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the experiment item.
        /// </param>
        /// <param name="experimentId">
        /// ID of the parent experiment.
        /// </param>
        /// <param name="datasetItemId">
        /// ID of the corresponding dataset item.
        /// </param>
        /// <param name="output">
        /// Output data from the experiment run.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItem(
            string? id,
            string? experimentId,
            string? datasetItemId,
            object? output,
            global::HammingAI.ExperimentItemMetrics? metrics,
            global::HammingAI.ExperimentItemStatus? status)
        {
            this.Id = id;
            this.ExperimentId = experimentId;
            this.DatasetItemId = datasetItemId;
            this.Output = output;
            this.Metrics = metrics;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItem" /> class.
        /// </summary>
        public ExperimentItem()
        {
        }
    }
}