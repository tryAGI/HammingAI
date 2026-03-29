
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentRequest
    {
        /// <summary>
        /// Name of the experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Dataset ID to run the experiment against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HammingAI.JsonConverters.ExperimentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HammingAI.ExperimentStatus Status { get; set; }

        /// <summary>
        /// Array of scoring types to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring")]
        public global::System.Collections.Generic.IList<string>? Scoring { get; set; }

        /// <summary>
        /// Additional metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Number of samples per dataset item (max 10).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        public int? Sampling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the experiment.
        /// </param>
        /// <param name="dataset">
        /// Dataset ID to run the experiment against.
        /// </param>
        /// <param name="status"></param>
        /// <param name="scoring">
        /// Array of scoring types to apply.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata.
        /// </param>
        /// <param name="sampling">
        /// Number of samples per dataset item (max 10).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentRequest(
            string name,
            string dataset,
            global::HammingAI.ExperimentStatus status,
            global::System.Collections.Generic.IList<string>? scoring,
            object? metadata,
            int? sampling)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Status = status;
            this.Scoring = scoring;
            this.Metadata = metadata;
            this.Sampling = sampling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRequest" /> class.
        /// </summary>
        public CreateExperimentRequest()
        {
        }
    }
}