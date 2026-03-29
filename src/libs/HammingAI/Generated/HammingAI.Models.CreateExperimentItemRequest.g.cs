
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentItemRequest
    {
        /// <summary>
        /// ID of the dataset item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetItemId { get; set; }

        /// <summary>
        /// Initial output (typically empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Initial metrics (typically empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public object? Metrics { get; set; }

        /// <summary>
        /// Sample index for multi-sample experiments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleId")]
        public int? SampleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentItemRequest" /> class.
        /// </summary>
        /// <param name="datasetItemId">
        /// ID of the dataset item.
        /// </param>
        /// <param name="output">
        /// Initial output (typically empty).
        /// </param>
        /// <param name="metrics">
        /// Initial metrics (typically empty).
        /// </param>
        /// <param name="sampleId">
        /// Sample index for multi-sample experiments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentItemRequest(
            string datasetItemId,
            object? output,
            object? metrics,
            int? sampleId)
        {
            this.DatasetItemId = datasetItemId ?? throw new global::System.ArgumentNullException(nameof(datasetItemId));
            this.Output = output;
            this.Metrics = metrics;
            this.SampleId = sampleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentItemRequest" /> class.
        /// </summary>
        public CreateExperimentItemRequest()
        {
        }
    }
}