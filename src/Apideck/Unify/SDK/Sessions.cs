//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Apideck.Unify.SDK
{
    using Apideck.Unify.SDK.Hooks;
    using Apideck.Unify.SDK.Models.Components;
    using Apideck.Unify.SDK.Models.Errors;
    using Apideck.Unify.SDK.Models.Requests;
    using Apideck.Unify.SDK.Utils.Retries;
    using Apideck.Unify.SDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ISessions
    {

        /// <summary>
        /// Create Session
        /// 
        /// <remarks>
        /// Making a POST request to this endpoint will initiate a Hosted Vault session. Redirect the consumer to the returned<br/>
        /// URL to allow temporary access to manage their integrations and settings.<br/>
        /// <br/>
        /// Note: This is a short lived token that will expire after 1 hour (TTL: 3600).<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<VaultSessionsCreateResponse> CreateAsync(string? consumerId = null, string? appId = null, Session? session = null, RetryConfig? retryConfig = null);
    }

    public class Sessions: ISessions
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.4";
        private const string _sdkGenVersion = "2.471.2";
        private const string _openapiDocVersion = "10.8.2";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.4 2.471.2 10.8.2 Apideck.Unify.SDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Apideck.Unify.SDK.Models.Components.Security>? _securitySource;

        public Sessions(ISpeakeasyHttpClient client, Func<Apideck.Unify.SDK.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<VaultSessionsCreateResponse> CreateAsync(string? consumerId = null, string? appId = null, Session? session = null, RetryConfig? retryConfig = null)
        {
            var request = new VaultSessionsCreateRequest()
            {
                ConsumerId = consumerId,
                AppId = appId,
                Session = session,
            };
            request.ConsumerId ??= SDKConfiguration.ConsumerId;
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/vault/sessions";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "Session", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("vault.sessionsCreate", null, _securitySource);

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
                "5XX",
            };

            Func<Task<HttpResponseMessage>> retrySend = async () =>
            {
                var _httpRequest = await _client.CloneAsync(httpRequest);
                return await _client.SendAsync(_httpRequest);
            };
            var retries = new Apideck.Unify.SDK.Utils.Retries.Retries(retrySend, retryConfig, statusCodes);

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

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CreateSessionResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    var response = new VaultSessionsCreateResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CreateSessionResponse = obj;
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
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UnexpectedErrorResponse>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    var response = new VaultSessionsCreateResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.UnexpectedErrorResponse = obj;
                    return response;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
        }
    }
}