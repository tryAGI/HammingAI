
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLiveKitRoomsResponse
    {
        /// <summary>
        /// ID of the created experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rooms")]
        public global::System.Collections.Generic.IList<global::HammingAI.LiveKitRoom>? Rooms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveKitRoomsResponse" /> class.
        /// </summary>
        /// <param name="experimentId">
        /// ID of the created experiment.
        /// </param>
        /// <param name="rooms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLiveKitRoomsResponse(
            string? experimentId,
            global::System.Collections.Generic.IList<global::HammingAI.LiveKitRoom>? rooms)
        {
            this.ExperimentId = experimentId;
            this.Rooms = rooms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveKitRoomsResponse" /> class.
        /// </summary>
        public CreateLiveKitRoomsResponse()
        {
        }
    }
}