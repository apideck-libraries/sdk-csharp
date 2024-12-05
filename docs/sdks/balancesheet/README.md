# BalanceSheet
(*Accounting.BalanceSheet*)

## Overview

### Available Operations

* [Get](#get) - Get BalanceSheet

## Get

Get BalanceSheet

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingBalanceSheetOneRequest req = new AccountingBalanceSheetOneRequest() {
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Filter = new BalanceSheetFilter() {
        StartDate = "2021-01-01",
        EndDate = "2021-12-31",
        PeriodCount = 3,
        PeriodType = ApideckUnifySdk.Models.Components.PeriodType.Month,
    },
};

var res = await sdk.Accounting.BalanceSheet.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingBalanceSheetOneRequest](../../Models/Requests/AccountingBalanceSheetOneRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingBalanceSheetOneResponse](../../Models/Requests/AccountingBalanceSheetOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |