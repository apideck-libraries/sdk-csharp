# Logs
(*Vault.Logs*)

## Overview

### Available Operations

* [List](#list) - Get all consumer request logs

## List

This endpoint includes all consumer request logs.


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

VaultLogsAllRequest req = new VaultLogsAllRequest() {
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ConsumerId = "test-consumer",
    Filter = new LogsFilter() {
        ConnectorId = "crm+salesforce",
        StatusCode = 201D,
        ExcludeUnifiedApis = "vault,proxy",
    },
};

VaultLogsAllResponse? res = await sdk.Vault.Logs.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [VaultLogsAllRequest](../../Models/Requests/VaultLogsAllRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[VaultLogsAllResponse](../../Models/Requests/VaultLogsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |