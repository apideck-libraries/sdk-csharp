//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk
{
    using ApideckUnifySdk.Hooks;
    using ApideckUnifySdk.Models.Components;
    using ApideckUnifySdk.Models.Errors;
    using ApideckUnifySdk.Models.Requests;
    using ApideckUnifySdk.Utils;
    using ApideckUnifySdk.Utils.Retries;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public interface ILogs
    {

        /// <summary>
        /// Get all consumer request logs
        /// 
        /// <remarks>
        /// This endpoint includes all consumer request logs.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<VaultLogsAllResponse> ListAsync(VaultLogsAllRequest? request = null, RetryConfig? retryConfig = null);
    }

    public class Logs: ILogs
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.9.0";
        private const string _sdkGenVersion = "2.570.3";
        private const string _openapiDocVersion = "10.15.2";
        private const string _userAgent = "speakeasy-sdk/csharp 0.9.0 2.570.3 10.15.2 ApideckUnifySdk";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<ApideckUnifySdk.Models.Components.Security>? _securitySource;

        public Logs(ISpeakeasyHttpClient client, Func<ApideckUnifySdk.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<VaultLogsAllResponse> ListAsync(VaultLogsAllRequest? request = null, RetryConfig? retryConfig = null)
        {
            request.ConsumerId ??= SDKConfiguration.ConsumerId;
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/vault/logs", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "vault.logsAll", new List<string> {  }, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);
            if (retryConfig == null)
            {
                if (this.SDKConfiguration.RetryConfig != null)
                {
                    retryConfig = this.SDKConfiguration.RetryConfig;
                }
                else
                {
                    var backoff = new BackoffStrategy(
                        initialIntervalMs: 500L,
                        maxIntervalMs: 60000L,
                        maxElapsedTimeMs: 3600000L,
                        exponent: 1.5
                    );
                    retryConfig = new RetryConfig(
                        strategy: RetryConfig.RetryStrategy.BACKOFF,
                        backoff: backoff,
                        retryConnectionErrors: true
                    );
                }
            }

            List<string> statusCodes = new List<string>
            {
                "408",
                "500",
                "502",
                "503",
                "504",
            };

            Func<Task<HttpResponseMessage>> retrySend = async () =>
            {
                var _httpRequest = await _client.CloneAsync(httpRequest);
                return await _client.SendAsync(_httpRequest);
            };
            var retries = new ApideckUnifySdk.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await retries.Run();
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 402 || _statusCode == 404 || _statusCode == 422 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            
            Func<Task<VaultLogsAllResponse?>> nextFunc = async delegate()
            {
                var body = JObject.Parse(await httpResponse.Content.ReadAsStringAsync());
                var nextCursorToken = body.SelectToken("$.meta.cursors.next");

                if(nextCursorToken == null)
                {
                    return null;
                }
                var nextCursor = nextCursorToken.Value<string>();
                if (nextCursor == null)
                {
                    return null;
                }

                var newRequest = new VaultLogsAllRequest
                {
                    AppId = request?.AppId,
                    ConsumerId = request?.ConsumerId,
                    Filter = request?.Filter,
                    Cursor = nextCursor,
                    Limit = request?.Limit
                };

                return await ListAsync (
                    request: newRequest,
                    retryConfig: retryConfig
                );
            };

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetLogsResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    var response = new VaultLogsAllResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        },
                        Next = nextFunc
                    };
                    response.GetLogsResponse = obj;
                    return response;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<BadRequestResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UnauthorizedResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 402)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<PaymentRequiredResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 404)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<NotFoundResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 422)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UnprocessableResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UnexpectedErrorResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    var response = new VaultLogsAllResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        },
                        Next = nextFunc
                    };
                    response.UnexpectedErrorResponse = obj;
                    return response;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
        }
    }
}