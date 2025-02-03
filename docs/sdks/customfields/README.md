# CustomFields
(*Vault.CustomFields*)

## Overview

### Available Operations

* [List](#list) - Get resource custom fields

## List

This endpoint returns an custom fields on a connection resource.


### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

VaultCustomFieldsAllRequest req = new VaultCustomFieldsAllRequest() {
    UnifiedApi = "crm",
    ServiceId = "pipedrive",
    Resource = "leads",
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ResourceId = "1234",
};

var res = await sdk.Vault.CustomFields.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [VaultCustomFieldsAllRequest](../../Models/Requests/VaultCustomFieldsAllRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[VaultCustomFieldsAllResponse](../../Models/Requests/VaultCustomFieldsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |