# Proxy

## Overview

### Available Operations

* [Get](#get) - GET
* [Options](#options) - OPTIONS
* [Post](#post) - POST
* [Put](#put) - PUT
* [Patch](#patch) - PATCH
* [Delete](#delete) - DELETE

## Get

Proxies a downstream GET request to a service and injects the necessary credentials into a request stored in Vault. This allows you to have an additional security layer and logging without needing to rely on Unify for normalization.
**Note**: Vault will proxy all data to the downstream URL and method/verb in the headers.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxy.getProxy" method="get" path="/proxy" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

ProxyGetProxyRequest req = new ProxyGetProxyRequest() {
    ServiceId = "close",
    UnifiedApi = "hris",
    DownstreamUrl = "https://api.close.com/api/v1/lead",
    DownstreamAuthorization = "Bearer <token>",
};

var res = await sdk.Proxy.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ProxyGetProxyRequest](../../Models/Requests/ProxyGetProxyRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ProxyGetProxyResponse](../../Models/Requests/ProxyGetProxyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| ApideckUnifySdk.Models.Errors.Unauthorized | 401                                        | application/json                           |
| ApideckUnifySdk.Models.Errors.APIException | 4XX, 5XX                                   | \*/\*                                      |

## Options

Proxies a downstream OPTION request to a service and injects the necessary credentials into a request stored in Vault. This allows you to have an additional security layer and logging without needing to rely on Unify for normalization.
**Note**: Vault will proxy all data to the downstream URL and method/verb in the headers.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxy.optionsProxy" method="options" path="/proxy" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

ProxyOptionsProxyRequest req = new ProxyOptionsProxyRequest() {
    ServiceId = "close",
    UnifiedApi = "hris",
    DownstreamUrl = "https://api.close.com/api/v1/lead",
    DownstreamAuthorization = "Bearer <token>",
};

var res = await sdk.Proxy.OptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ProxyOptionsProxyRequest](../../Models/Requests/ProxyOptionsProxyRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ProxyOptionsProxyResponse](../../Models/Requests/ProxyOptionsProxyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| ApideckUnifySdk.Models.Errors.Unauthorized | 401                                        | application/json                           |
| ApideckUnifySdk.Models.Errors.APIException | 4XX, 5XX                                   | \*/\*                                      |

## Post

Proxies a downstream POST request to a service and injects the necessary credentials into a request stored in Vault. This allows you to have an additional security layer and logging without needing to rely on Unify for normalization.
**Note**: Vault will proxy all data to the downstream URL and method/verb in the headers.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxy.postProxy" method="post" path="/proxy" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

ProxyPostProxyRequest req = new ProxyPostProxyRequest() {
    ServiceId = "close",
    UnifiedApi = "hris",
    DownstreamUrl = "https://api.close.com/api/v1/lead",
    DownstreamAuthorization = "Bearer <token>",
};

var res = await sdk.Proxy.PostAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ProxyPostProxyRequest](../../Models/Requests/ProxyPostProxyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ProxyPostProxyResponse](../../Models/Requests/ProxyPostProxyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| ApideckUnifySdk.Models.Errors.Unauthorized | 401                                        | application/json                           |
| ApideckUnifySdk.Models.Errors.APIException | 4XX, 5XX                                   | \*/\*                                      |

## Put

Proxies a downstream PUT request to a service and injects the necessary credentials into a request stored in Vault. This allows you to have an additional security layer and logging without needing to rely on Unify for normalization.
**Note**: Vault will proxy all data to the downstream URL and method/verb in the headers.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxy.putProxy" method="put" path="/proxy" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

ProxyPutProxyRequest req = new ProxyPutProxyRequest() {
    ServiceId = "close",
    UnifiedApi = "hris",
    DownstreamUrl = "https://api.close.com/api/v1/lead",
    DownstreamAuthorization = "Bearer <token>",
};

var res = await sdk.Proxy.PutAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ProxyPutProxyRequest](../../Models/Requests/ProxyPutProxyRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ProxyPutProxyResponse](../../Models/Requests/ProxyPutProxyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| ApideckUnifySdk.Models.Errors.Unauthorized | 401                                        | application/json                           |
| ApideckUnifySdk.Models.Errors.APIException | 4XX, 5XX                                   | \*/\*                                      |

## Patch

Proxies a downstream PATCH request to a service and injects the necessary credentials into a request stored in Vault. This allows you to have an additional security layer and logging without needing to rely on Unify for normalization.
**Note**: Vault will proxy all data to the downstream URL and method/verb in the headers.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxy.patchProxy" method="patch" path="/proxy" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

ProxyPatchProxyRequest req = new ProxyPatchProxyRequest() {
    ServiceId = "close",
    UnifiedApi = "hris",
    DownstreamUrl = "https://api.close.com/api/v1/lead",
    DownstreamAuthorization = "Bearer <token>",
};

var res = await sdk.Proxy.PatchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ProxyPatchProxyRequest](../../Models/Requests/ProxyPatchProxyRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ProxyPatchProxyResponse](../../Models/Requests/ProxyPatchProxyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| ApideckUnifySdk.Models.Errors.Unauthorized | 401                                        | application/json                           |
| ApideckUnifySdk.Models.Errors.APIException | 4XX, 5XX                                   | \*/\*                                      |

## Delete

Proxies a downstream DELETE request to a service and injects the necessary credentials into a request stored in Vault. This allows you to have an additional security layer and logging without needing to rely on Unify for normalization.
**Note**: Vault will proxy all data to the downstream URL and method/verb in the headers.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxy.deleteProxy" method="delete" path="/proxy" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

ProxyDeleteProxyRequest req = new ProxyDeleteProxyRequest() {
    ServiceId = "close",
    UnifiedApi = "hris",
    DownstreamUrl = "https://api.close.com/api/v1/lead",
    DownstreamAuthorization = "Bearer <token>",
};

var res = await sdk.Proxy.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ProxyDeleteProxyRequest](../../Models/Requests/ProxyDeleteProxyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ProxyDeleteProxyResponse](../../Models/Requests/ProxyDeleteProxyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| ApideckUnifySdk.Models.Errors.Unauthorized | 401                                        | application/json                           |
| ApideckUnifySdk.Models.Errors.APIException | 4XX, 5XX                                   | \*/\*                                      |