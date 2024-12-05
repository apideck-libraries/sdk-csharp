# CustomMappings
(*Vault.CustomMappings*)

## Overview

### Available Operations

* [List](#list) - List custom mappings

## List

This endpoint returns a list of custom mappings.

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Vault.CustomMappings.ListAsync(
    unifiedApi: "crm",
    serviceId: "pipedrive",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                                                  | Type                                                       | Required                                                   | Description                                                | Example                                                    |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `UnifiedApi`                                               | *string*                                                   | :heavy_check_mark:                                         | Unified API                                                | crm                                                        |
| `ServiceId`                                                | *string*                                                   | :heavy_check_mark:                                         | Service ID of the resource to return                       | pipedrive                                                  |
| `ConsumerId`                                               | *string*                                                   | :heavy_minus_sign:                                         | ID of the consumer which you want to get or push data from | test-consumer                                              |
| `AppId`                                                    | *string*                                                   | :heavy_minus_sign:                                         | The ID of your Unify application                           | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                    |

### Response

**[VaultCustomMappingsAllResponse](../../Models/Requests/VaultCustomMappingsAllResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.BadRequestResponse      | 400                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnprocessableResponse   | 422                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |