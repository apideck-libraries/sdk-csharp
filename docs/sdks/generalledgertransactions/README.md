# Accounting.GeneralLedgerTransactions

## Overview

### Available Operations

* [List](#list) - List General Ledger Transactions
* [Get](#get) - Get General Ledger Transaction

## List

List General Ledger Transactions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.generalLedgerTransactionsAll" method="get" path="/accounting/general-ledger-transactions" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingGeneralLedgerTransactionsAllRequest req = new AccountingGeneralLedgerTransactionsAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Filter = new GeneralLedgerTransactionsFilter() {
        SourceType = SourceType.Invoice,
        UpdatedSince = System.DateTime.Parse("2024-09-30T07:43:32.000Z").ToUniversalTime(),
    },
    Sort = new GeneralLedgerTransactionsSort() {
        By = GeneralLedgerTransactionsSortBy.PostedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingGeneralLedgerTransactionsAllResponse? res = await sdk.Accounting.GeneralLedgerTransactions.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [AccountingGeneralLedgerTransactionsAllRequest](../../Models/Requests/AccountingGeneralLedgerTransactionsAllRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |

### Response

**[AccountingGeneralLedgerTransactionsAllResponse](../../Models/Requests/AccountingGeneralLedgerTransactionsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Get

Get General Ledger Transaction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.generalLedgerTransactionsOne" method="get" path="/accounting/general-ledger-transactions/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingGeneralLedgerTransactionsOneRequest req = new AccountingGeneralLedgerTransactionsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.GeneralLedgerTransactions.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [AccountingGeneralLedgerTransactionsOneRequest](../../Models/Requests/AccountingGeneralLedgerTransactionsOneRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |

### Response

**[AccountingGeneralLedgerTransactionsOneResponse](../../Models/Requests/AccountingGeneralLedgerTransactionsOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |