
#nullable enable

namespace HammingAI
{
    public partial class ExperimentsClient
    {
        partial void PrepareUpdateExperimentItemArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string experimentId,
            ref string itemId,
            global::HammingAI.UpdateExperimentItemRequest request);
        partial void PrepareUpdateExperimentItemRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string experimentId,
            string itemId,
            global::HammingAI.UpdateExperimentItemRequest request);
        partial void ProcessUpdateExperimentItemResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update an experiment item<br/>
        /// Updates an experiment item with output, scores, and metrics after execution.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HammingAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UpdateExperimentItemAsync(
            string experimentId,
            string itemId,

            global::HammingAI.UpdateExperimentItemRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateExperimentItemArguments(
                httpClient: HttpClient,
                experimentId: ref experimentId,
                itemId: ref itemId,
                request: request);

            var __pathBuilder = new global::HammingAI.PathBuilder(
                path: $"/experiments/{experimentId}/items/{itemId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareUpdateExperimentItemRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                experimentId: experimentId,
                itemId: itemId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateExperimentItemResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Update an experiment item<br/>
        /// Updates an experiment item with output, scores, and metrics after execution.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="itemId"></param>
        /// <param name="output">
        /// Output data from the experiment run.
        /// </param>
        /// <param name="scores">
        /// Scores keyed by scoring function name.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="failed">
        /// Whether the item execution failed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateExperimentItemAsync(
            string experimentId,
            string itemId,
            object? output = default,
            global::System.Collections.Generic.Dictionary<string, global::HammingAI.Score>? scores = default,
            global::HammingAI.ExperimentItemMetrics? metrics = default,
            bool? failed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HammingAI.UpdateExperimentItemRequest
            {
                Output = output,
                Scores = scores,
                Metrics = metrics,
                Failed = failed,
            };

            await UpdateExperimentItemAsync(
                experimentId: experimentId,
                itemId: itemId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}