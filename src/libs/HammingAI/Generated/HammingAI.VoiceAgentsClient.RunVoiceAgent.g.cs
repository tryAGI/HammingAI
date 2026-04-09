
#nullable enable

namespace HammingAI
{
    public partial class VoiceAgentsClient
    {


        private static readonly global::HammingAI.EndPointSecurityRequirement s_RunVoiceAgentSecurityRequirement0 =
            new global::HammingAI.EndPointSecurityRequirement
            {
                Authorizations = new global::HammingAI.EndPointAuthorizationRequirement[]
                {                    new global::HammingAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::HammingAI.EndPointSecurityRequirement[] s_RunVoiceAgentSecurityRequirements =
            new global::HammingAI.EndPointSecurityRequirement[]
            {                s_RunVoiceAgentSecurityRequirement0,
            };
        partial void PrepareRunVoiceAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            global::HammingAI.RunVoiceAgentRequest request);
        partial void PrepareRunVoiceAgentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            global::HammingAI.RunVoiceAgentRequest request);
        partial void ProcessRunVoiceAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRunVoiceAgentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Run voice agent test<br/>
        /// Initiates a voice agent test run by making parallel calls using the specified dataset scenarios. Returns a voice experiment ID that can be used to track status and results.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HammingAI.RunVoiceAgentResponse> RunVoiceAgentAsync(
            string agentId,

            global::HammingAI.RunVoiceAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRunVoiceAgentArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                request: request);


            var __authorizations = global::HammingAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RunVoiceAgentSecurityRequirements,
                operationName: "RunVoiceAgentAsync");

            var __pathBuilder = new global::HammingAI.PathBuilder(
                path: $"/voice-agent/{agentId}/run",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRunVoiceAgentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRunVoiceAgentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessRunVoiceAgentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HammingAI.RunVoiceAgentResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::HammingAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::HammingAI.RunVoiceAgentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::HammingAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Run voice agent test<br/>
        /// Initiates a voice agent test run by making parallel calls using the specified dataset scenarios. Returns a voice experiment ID that can be used to track status and results.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toNumber">
        /// Phone number to call for the voice agent test.
        /// </param>
        /// <param name="datasetId">
        /// Dataset ID containing test scenarios.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HammingAI.RunVoiceAgentResponse> RunVoiceAgentAsync(
            string agentId,
            string toNumber,
            string datasetId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HammingAI.RunVoiceAgentRequest
            {
                ToNumber = toNumber,
                DatasetId = datasetId,
            };

            return await RunVoiceAgentAsync(
                agentId: agentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}