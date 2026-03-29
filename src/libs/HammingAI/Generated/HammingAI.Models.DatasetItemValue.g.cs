
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemValue
    {
        /// <summary>
        /// Input data for the dataset item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Expected output data for the dataset item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Additional metadata for the dataset item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemValue" /> class.
        /// </summary>
        /// <param name="input">
        /// Input data for the dataset item.
        /// </param>
        /// <param name="output">
        /// Expected output data for the dataset item.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the dataset item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemValue(
            object? input,
            object? output,
            object? metadata)
        {
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemValue" /> class.
        /// </summary>
        public DatasetItemValue()
        {
        }
    }
}