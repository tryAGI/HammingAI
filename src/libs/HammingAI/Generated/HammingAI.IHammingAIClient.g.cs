
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// API for testing and monitoring AI voice agents. Hamming provides automated voice agent testing, evaluation, production monitoring, datasets, experiments, prompts, and tracing for voice agents built on Vapi, RetellAI, Bland, LiveKit, and other platforms.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IHammingAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::HammingAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::HammingAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments { get; }

        /// <summary>
        /// 
        /// </summary>
        public MonitoringClient Monitoring { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScoringClient Scoring { get; }

        /// <summary>
        /// 
        /// </summary>
        public TracingClient Tracing { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceAgentsClient VoiceAgents { get; }

    }
}