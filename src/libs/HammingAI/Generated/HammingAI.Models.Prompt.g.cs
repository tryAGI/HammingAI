
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt
    {
        /// <summary>
        /// Prompt slug identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        /// <param name="slug">
        /// Prompt slug identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt(
            string? slug)
        {
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        public Prompt()
        {
        }
    }
}