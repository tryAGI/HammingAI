
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptContent
    {
        /// <summary>
        /// Language model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageModel")]
        public string? LanguageModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptSettings")]
        public global::HammingAI.PromptSettings? PromptSettings { get; set; }

        /// <summary>
        /// Chat messages in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatMessages")]
        public global::System.Collections.Generic.IList<global::HammingAI.ChatMessage>? ChatMessages { get; set; }

        /// <summary>
        /// Tool definitions as a JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public string? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptContent" /> class.
        /// </summary>
        /// <param name="languageModel">
        /// Language model identifier.
        /// </param>
        /// <param name="promptSettings"></param>
        /// <param name="chatMessages">
        /// Chat messages in the prompt.
        /// </param>
        /// <param name="tools">
        /// Tool definitions as a JSON string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptContent(
            string? languageModel,
            global::HammingAI.PromptSettings? promptSettings,
            global::System.Collections.Generic.IList<global::HammingAI.ChatMessage>? chatMessages,
            string? tools)
        {
            this.LanguageModel = languageModel;
            this.PromptSettings = promptSettings;
            this.ChatMessages = chatMessages;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptContent" /> class.
        /// </summary>
        public PromptContent()
        {
        }
    }
}