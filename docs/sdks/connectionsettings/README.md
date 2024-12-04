# ConnectionSettings
(*Vault.ConnectionSettings*)

## Overview

### Available Operations

* [List](#list) - Get resource settings
* [Update](#update) - Update settings

## List

This endpoint returns custom settings and their defaults required by connection for a given resource.


### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using ApiDeckSdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
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

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |

## Update

Update default values for a connection's resource settings

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using ApiDeckSdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
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
            { "account", new Dictionary<string, object>() {
                { "name", "My Company" },
                { "id", "c01458a5-7276-41ce-bc19-639906b0450a" },
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
                            FormFieldOption.CreateFormFieldOptionGroup(
                                new FormFieldOptionGroup() {
                                    Id = "1234",
                                    Label = "General Channel",
                                    Options = new List<SimpleFormFieldOption>() {
                                        new SimpleFormFieldOption() {
                                            Label = "General Channel",
                                            Value = SimpleFormFieldOptionValue.CreateNumber(
                                                12.5D
                                            ),
                                        },
                                    },
                                }
                            ),
                        },
                        Value = ConnectionValue.CreateInteger(
                            10
                        ),
                    },
                },
            },
        },
        CustomMappings = new List<CustomMappingInput>() {
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

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |