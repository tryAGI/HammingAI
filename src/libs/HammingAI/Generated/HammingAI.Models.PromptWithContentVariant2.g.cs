
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptWithContentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::HammingAI.PromptContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWithContentVariant2" /> class.
        /// </summary>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptWithContentVariant2(
            global::HammingAI.PromptContent? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWithContentVariant2" /> class.
        /// </summary>
        public PromptWithContentVariant2()
        {
        }
    }
}