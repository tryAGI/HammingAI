
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Experiment
    {
        /// <summary>
        /// Unique identifier for the experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// ID of the dataset used for this experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Optional dataset version ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetVersionId")]
        public int? DatasetVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HammingAI.JsonConverters.ExperimentStatusJsonConverter))]
        public global::HammingAI.ExperimentStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the experiment.
        /// </param>
        /// <param name="name">
        /// Name of the experiment.
        /// </param>
        /// <param name="description">
        /// Optional description.
        /// </param>
        /// <param name="datasetId">
        /// ID of the dataset used for this experiment.
        /// </param>
        /// <param name="datasetVersionId">
        /// Optional dataset version ID.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Experiment(
            string? id,
            string? name,
            string? description,
            string? datasetId,
            int? datasetVersionId,
            global::HammingAI.ExperimentStatus? status)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DatasetId = datasetId;
            this.DatasetVersionId = datasetVersionId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        public Experiment()
        {
        }
    }
}