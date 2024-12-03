# Logs
(*Vault.Logs*)

## Overview

### Available Operations

* [List](#list) - Get all consumer request logs

## List

This endpoint includes all consumer request logs.


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

VaultLogsAllRequest req = new VaultLogsAllRequest() {
    Filter = new LogsFilter() {
        ConnectorId = "crm+salesforce",
        StatusCode = 201D,
        ExcludeUnifiedApis = "vault,proxy",
    },
};

var res = await sdk.Vault.Logs.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [VaultLogsAllRequest](../../Models/Requests/VaultLogsAllRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[VaultLogsAllResponse](../../Models/Requests/VaultLogsAllResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |