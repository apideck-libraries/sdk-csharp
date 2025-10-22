# Connections
(*Vault.Connections*)

## Overview

### Available Operations

* [List](#list) - Get all connections
* [Get](#get) - Get connection
* [Update](#update) - Update connection
* [Delete](#delete) - Deletes a connection
* [Imports](#imports) - Import connection
* [Token](#token) - Authorize Access Token

## List

This endpoint includes all the configured integrations and contains the required assets
to build an integrations page where your users can install integrations.
OAuth2 supported integrations will contain authorize and revoke links to handle the authentication flows.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionsAll" method="get" path="/vault/connections" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Connections.ListAsync(
    api: "crm",
    configured: true
);

// handle response
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    | Example                                                        |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `ConsumerId`                                                   | *string*                                                       | :heavy_minus_sign:                                             | ID of the consumer which you want to get or push data from     | test-consumer                                                  |
| `AppId`                                                        | *string*                                                       | :heavy_minus_sign:                                             | The ID of your Unify application                               | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                        |
| `Api`                                                          | *string*                                                       | :heavy_minus_sign:                                             | Scope results to Unified API                                   | crm                                                            |
| `Configured`                                                   | *bool*                                                         | :heavy_minus_sign:                                             | Scopes results to connections that have been configured or not | true                                                           |

### Response

**[VaultConnectionsAllResponse](../../Models/Requests/VaultConnectionsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Get

Get a connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionsOne" method="get" path="/vault/connections/{unified_api}/{service_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Connections.GetAsync(
    serviceId: "pipedrive",
    unifiedApi: "crm"
);

// handle response
```

### Parameters

| Parameter                                                  | Type                                                       | Required                                                   | Description                                                | Example                                                    |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `ServiceId`                                                | *string*                                                   | :heavy_check_mark:                                         | Service ID of the resource to return                       | pipedrive                                                  |
| `UnifiedApi`                                               | *string*                                                   | :heavy_check_mark:                                         | Unified API                                                | crm                                                        |
| `ConsumerId`                                               | *string*                                                   | :heavy_minus_sign:                                         | ID of the consumer which you want to get or push data from | test-consumer                                              |
| `AppId`                                                    | *string*                                                   | :heavy_minus_sign:                                         | The ID of your Unify application                           | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                    |

### Response

**[VaultConnectionsOneResponse](../../Models/Requests/VaultConnectionsOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Update

Update a connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionsUpdate" method="patch" path="/vault/connections/{unified_api}/{service_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

VaultConnectionsUpdateRequest req = new VaultConnectionsUpdateRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
    Connection = new ConnectionInput() {
        Enabled = true,
        Settings = new Dictionary<string, object>() {
            { "instance_url", "https://eu28.salesforce.com" },
            { "api_key", "12345xxxxxx" },
        },
        Metadata = new Dictionary<string, object>() {
            { "account", new Dictionary<string, object>() {
                { "id", "c01458a5-7276-41ce-bc19-639906b0450a" },
                { "name", "My Company" },
            } },
            { "plan", "enterprise" },
        },
        Configuration = new List<ConnectionConfiguration>() {
            new ConnectionConfiguration() {
                Resource = "leads",
                Defaults = new List<ConnectionDefaults>() {
                    new ConnectionDefaults() {
                        Id = "ProductInterest",
                        Options = new List<FormFieldOption>() {
                            FormFieldOption.CreateGroup(
                                new FormFieldOptionGroup() {
                                    Label = "General Channel",
                                    Options = new List<SimpleFormFieldOption>() {},
                                    OptionType = FormFieldOptionGroupOptionType.Group,
                                }
                            ),
                            FormFieldOption.CreateSimple(
                                new SimpleFormFieldOption() {
                                    Label = "General Channel",
                                    OptionType = OptionType.Simple,
                                }
                            ),
                        },
                        Value = ConnectionValue.CreateStr(
                            "GC5000 series"
                        ),
                    },
                    new ConnectionDefaults() {
                        Id = "ProductInterest",
                        Options = new List<FormFieldOption>() {
                            FormFieldOption.CreateGroup(
                                new FormFieldOptionGroup() {
                                    Label = "General Channel",
                                    Options = new List<SimpleFormFieldOption>() {},
                                    OptionType = FormFieldOptionGroupOptionType.Group,
                                }
                            ),
                            FormFieldOption.CreateSimple(
                                new SimpleFormFieldOption() {
                                    Label = "General Channel",
                                    OptionType = OptionType.Simple,
                                }
                            ),
                        },
                        Value = ConnectionValue.CreateStr(
                            "GC5000 series"
                        ),
                    },
                },
            },
            new ConnectionConfiguration() {
                Resource = "leads",
                Defaults = new List<ConnectionDefaults>() {
                    new ConnectionDefaults() {
                        Id = "ProductInterest",
                        Options = new List<FormFieldOption>() {
                            FormFieldOption.CreateGroup(
                                new FormFieldOptionGroup() {
                                    Label = "General Channel",
                                    Options = new List<SimpleFormFieldOption>() {},
                                    OptionType = FormFieldOptionGroupOptionType.Group,
                                }
                            ),
                            FormFieldOption.CreateSimple(
                                new SimpleFormFieldOption() {
                                    Label = "General Channel",
                                    OptionType = OptionType.Simple,
                                }
                            ),
                        },
                        Value = ConnectionValue.CreateStr(
                            "GC5000 series"
                        ),
                    },
                    new ConnectionDefaults() {
                        Id = "ProductInterest",
                        Options = new List<FormFieldOption>() {
                            FormFieldOption.CreateGroup(
                                new FormFieldOptionGroup() {
                                    Label = "General Channel",
                                    Options = new List<SimpleFormFieldOption>() {},
                                    OptionType = FormFieldOptionGroupOptionType.Group,
                                }
                            ),
                            FormFieldOption.CreateSimple(
                                new SimpleFormFieldOption() {
                                    Label = "General Channel",
                                    OptionType = OptionType.Simple,
                                }
                            ),
                        },
                        Value = ConnectionValue.CreateStr(
                            "GC5000 series"
                        ),
                    },
                },
            },
        },
        CustomMappings = new List<CustomMappingInput>() {
            new CustomMappingInput() {
                Value = "$.root.training.first_aid",
            },
            new CustomMappingInput() {
                Value = "$.root.training.first_aid",
            },
            new CustomMappingInput() {
                Value = "$.root.training.first_aid",
            },
        },
    },
};

var res = await sdk.Vault.Connections.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [VaultConnectionsUpdateRequest](../../Models/Requests/VaultConnectionsUpdateRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[VaultConnectionsUpdateResponse](../../Models/Requests/VaultConnectionsUpdateResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Delete

Deletes a connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionsDelete" method="delete" path="/vault/connections/{unified_api}/{service_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Connections.DeleteAsync(
    serviceId: "pipedrive",
    unifiedApi: "crm"
);

// handle response
```

### Parameters

| Parameter                                                  | Type                                                       | Required                                                   | Description                                                | Example                                                    |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `ServiceId`                                                | *string*                                                   | :heavy_check_mark:                                         | Service ID of the resource to return                       | pipedrive                                                  |
| `UnifiedApi`                                               | *string*                                                   | :heavy_check_mark:                                         | Unified API                                                | crm                                                        |
| `ConsumerId`                                               | *string*                                                   | :heavy_minus_sign:                                         | ID of the consumer which you want to get or push data from | test-consumer                                              |
| `AppId`                                                    | *string*                                                   | :heavy_minus_sign:                                         | The ID of your Unify application                           | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                    |

### Response

**[VaultConnectionsDeleteResponse](../../Models/Requests/VaultConnectionsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Imports

Import an authorized connection.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionsImport" method="post" path="/vault/connections/{unified_api}/{service_id}/import" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

VaultConnectionsImportRequest req = new VaultConnectionsImportRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
    ConnectionImportData = new ConnectionImportData() {
        Credentials = new Credentials() {
            RefreshToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.cThIIoDvwdueQB468K5xDc5633seEFoqwxjF_xSJyQQ",
            AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c",
        },
        Settings = new Dictionary<string, object>() {
            { "instance_url", "https://eu28.salesforce.com" },
        },
        Metadata = new Dictionary<string, object>() {
            { "account", new Dictionary<string, object>() {
                { "name", "My Company" },
                { "id", "c01458a5-7276-41ce-bc19-639906b0450a" },
            } },
            { "plan", "enterprise" },
        },
    },
};

var res = await sdk.Vault.Connections.ImportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [VaultConnectionsImportRequest](../../Models/Requests/VaultConnectionsImportRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[VaultConnectionsImportResponse](../../Models/Requests/VaultConnectionsImportResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Token

Triggers exchanging persisted connection credentials for an access token and store it in Vault. Currently supported for connections with the `client_credentials` or `password` OAuth grant type.

Note:
  - Do not include any credentials in the request body. This operation does not persist changes, but only triggers the exchange of persisted connection credentials for an access token.
  - The access token will not be returned in the response. A 200 response code indicates the authorization was successful and that a valid access token was stored on the connection.
  - The access token will be used for subsequent API requests.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionsToken" method="post" path="/vault/connections/{unified_api}/{service_id}/token" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

VaultConnectionsTokenRequest req = new VaultConnectionsTokenRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
};

var res = await sdk.Vault.Connections.TokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [VaultConnectionsTokenRequest](../../Models/Requests/VaultConnectionsTokenRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[VaultConnectionsTokenResponse](../../Models/Requests/VaultConnectionsTokenResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |