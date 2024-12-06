# ConsumerRequestCounts
(*Vault.ConsumerRequestCounts*)

## Overview

### Available Operations

* [List](#list) - Consumer request counts

## List

Get consumer request counts within a given datetime range.


### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Vault.ConsumerRequestCounts.ListAsync(
    consumerId: "test_user_id",
    startDatetime: "2021-05-01T12:00:00.000Z",
    endDatetime: "2021-05-30T12:00:00.000Z",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ConsumerId`                                             | *string*                                                 | :heavy_check_mark:                                       | ID of the consumer to return                             | test_user_id                                             |
| `StartDatetime`                                          | *string*                                                 | :heavy_check_mark:                                       | Scopes results to requests that happened after datetime  | 2021-05-01T12:00:00.000Z                                 |
| `EndDatetime`                                            | *string*                                                 | :heavy_check_mark:                                       | Scopes results to requests that happened before datetime | 2021-05-30T12:00:00.000Z                                 |
| `AppId`                                                  | *string*                                                 | :heavy_minus_sign:                                       | The ID of your Unify application                         | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                  |

### Response

**[VaultConsumerRequestCountsAllResponse](../../Models/Requests/VaultConsumerRequestCountsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |