# Accounting.TrialBalance

## Overview

### Available Operations

* [Get](#get) - Get Trial Balance

## Get

Get the trial balance as of a date. Read-only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.trialBalanceOne" method="get" path="/accounting/trial-balance" -->
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

AccountingTrialBalanceOneRequest req = new AccountingTrialBalanceOneRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Filter = new TrialBalanceFilter() {
        EndDate = "2025-12-31",
        AccountingMethod = TrialBalanceFilterAccountingMethod.Accrual,
    },
};

var res = await sdk.Accounting.TrialBalance.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingTrialBalanceOneRequest](../../Models/Requests/AccountingTrialBalanceOneRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingTrialBalanceOneResponse](../../Models/Requests/AccountingTrialBalanceOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |