# ProfitAndLoss
(*Accounting.ProfitAndLoss*)

## Overview

### Available Operations

* [Get](#get) - Get Profit and Loss

## Get

Get Profit and Loss

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingProfitAndLossOneRequest req = new AccountingProfitAndLossOneRequest() {
    ServiceId = "salesforce",
    Filter = new ProfitAndLossFilter() {
        CustomerId = "123abc",
        StartDate = "2021-01-01",
        EndDate = "2021-12-31",
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.ProfitAndLoss.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingProfitAndLossOneRequest](../../Models/Requests/AccountingProfitAndLossOneRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingProfitAndLossOneResponse](../../Models/Requests/AccountingProfitAndLossOneResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |