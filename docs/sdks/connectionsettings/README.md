# Vault.ConnectionSettings

## Overview

### Available Operations

* [List](#list) - Get resource settings
* [Update](#update) - Update settings

## List

This endpoint returns custom settings and their defaults required by connection for a given resource.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionSettingsAll" method="get" path="/vault/connections/{unified_api}/{service_id}/{resource}/config" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

VaultConnectionSettingsAllRequest req = new VaultConnectionSettingsAllRequest() {
    UnifiedApi = "crm",
    ServiceId = "pipedrive",
    Resource = "leads",
};

var res = await sdk.Vault.ConnectionSettings.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [VaultConnectionSettingsAllRequest](../../Models/Requests/VaultConnectionSettingsAllRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[VaultConnectionSettingsAllResponse](../../Models/Requests/VaultConnectionSettingsAllResponse.md)**

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

Update default values for a connection's resource settings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionSettingsUpdate" method="patch" path="/vault/connections/{unified_api}/{service_id}/{resource}/config" -->
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

VaultConnectionSettingsUpdateRequest req = new VaultConnectionSettingsUpdateRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
    Resource = "leads",
    Connection = new ConnectionInput() {
        Enabled = true,
        Settings = new Dictionary<string, object>() {
            { "instance_url", "https://eu28.salesforce.com" },
            { "api_key", "12345xxxxxx" },
        },
        Metadata = new Dictionary<string, object>() {
            { "plan", "enterprise" },
            { "account", new Dictionary<string, object>() {
                { "name", "My Company" },
                { "id", "c01458a5-7276-41ce-bc19-639906b0450a" },
            } },
        },
        Configuration = new List<ConnectionConfiguration>() {
            new ConnectionConfiguration() {
                Resource = "leads",
                Defaults = new List<ConnectionDefaults>() {
                    new ConnectionDefaults() {
                        Id = "ProductInterest",
                        Options = new List<FormFieldOption>() {
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
        },
    },
};

var res = await sdk.Vault.ConnectionSettings.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [VaultConnectionSettingsUpdateRequest](../../Models/Requests/VaultConnectionSettingsUpdateRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[VaultConnectionSettingsUpdateResponse](../../Models/Requests/VaultConnectionSettingsUpdateResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |