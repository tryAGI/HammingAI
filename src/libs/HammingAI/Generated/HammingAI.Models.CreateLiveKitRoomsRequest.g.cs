
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLiveKitRoomsRequest
    {
        /// <summary>
        /// Dataset ID for the test run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Array of dataset item IDs to create rooms for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DatasetItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveKitRoomsRequest" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset ID for the test run.
        /// </param>
        /// <param name="datasetItemIds">
        /// Array of dataset item IDs to create rooms for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLiveKitRoomsRequest(
            string datasetId,
            global::System.Collections.Generic.IList<string> datasetItemIds)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.DatasetItemIds = datasetItemIds ?? throw new global::System.ArgumentNullException(nameof(datasetItemIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveKitRoomsRequest" /> class.
        /// </summary>
        public CreateLiveKitRoomsRequest()
        {
        }
    }
}