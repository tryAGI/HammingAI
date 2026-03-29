
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentTrace
    {
        /// <summary>
        /// Local trace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// ID of the experiment item this trace belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentItemId")]
        public string? ExperimentItemId { get; set; }

        /// <summary>
        /// ID of the parent trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public int? ParentId { get; set; }

        /// <summary>
        /// A trace event containing arbitrary key-value data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public global::HammingAI.TraceEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTrace" /> class.
        /// </summary>
        /// <param name="id">
        /// Local trace ID.
        /// </param>
        /// <param name="experimentItemId">
        /// ID of the experiment item this trace belongs to.
        /// </param>
        /// <param name="parentId">
        /// ID of the parent trace.
        /// </param>
        /// <param name="event">
        /// A trace event containing arbitrary key-value data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentTrace(
            int? id,
            string? experimentItemId,
            int? parentId,
            global::HammingAI.TraceEvent? @event)
        {
            this.Id = id;
            this.ExperimentItemId = experimentItemId;
            this.ParentId = parentId;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTrace" /> class.
        /// </summary>
        public ExperimentTrace()
        {
        }
    }
}