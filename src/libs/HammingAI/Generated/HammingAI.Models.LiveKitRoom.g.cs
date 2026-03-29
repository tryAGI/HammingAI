
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiveKitRoom
    {
        /// <summary>
        /// Name of the LiveKit room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roomName")]
        public string? RoomName { get; set; }

        /// <summary>
        /// URL for connecting to the room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Associated dataset item ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemId")]
        public string? DatasetItemId { get; set; }

        /// <summary>
        /// Authentication token for the room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveKitRoom" /> class.
        /// </summary>
        /// <param name="roomName">
        /// Name of the LiveKit room.
        /// </param>
        /// <param name="url">
        /// URL for connecting to the room.
        /// </param>
        /// <param name="datasetItemId">
        /// Associated dataset item ID.
        /// </param>
        /// <param name="token">
        /// Authentication token for the room.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveKitRoom(
            string? roomName,
            string? url,
            string? datasetItemId,
            string? token)
        {
            this.RoomName = roomName;
            this.Url = url;
            this.DatasetItemId = datasetItemId;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveKitRoom" /> class.
        /// </summary>
        public LiveKitRoom()
        {
        }
    }
}