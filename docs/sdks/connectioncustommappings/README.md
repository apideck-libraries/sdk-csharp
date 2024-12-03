# ConnectionCustomMappings
(*Vault.ConnectionCustomMappings*)

## Overview

### Available Operations

* [List](#list) - List connection custom mappings

## List

This endpoint returns a list of custom mappings for a connection.

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

VaultConnectionCustomMappingsAllRequest req = new VaultConnectionCustomMappingsAllRequest() {
    UnifiedApi = "crm",
    ServiceId = "pipedrive",
    Resource = "leads",
    ResourceId = "1234",
};

var res = await sdk.Vault.ConnectionCustomMappings.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [VaultConnectionCustomMappingsAllRequest](../../Models/Requests/VaultConnectionCustomMappingsAllRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[VaultConnectionCustomMappingsAllResponse](../../Models/Requests/VaultConnectionCustomMappingsAllResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |