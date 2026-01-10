# Accounting.BankFeedStatements

## Overview

### Available Operations

* [List](#list) - List Bank Feed Statements
* [Create](#create) - Create Bank Feed Statement
* [Get](#get) - Get Bank Feed Statement
* [Update](#update) - Update Bank Feed Statement
* [Delete](#delete) - Delete Bank Feed Statement

## List

List Bank Feed Statements

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.bankFeedStatementsAll" method="get" path="/accounting/bank-feed-statements" -->
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

AccountingBankFeedStatementsAllRequest req = new AccountingBankFeedStatementsAllRequest() {
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingBankFeedStatementsAllResponse? res = await sdk.Accounting.BankFeedStatements.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [AccountingBankFeedStatementsAllRequest](../../Models/Requests/AccountingBankFeedStatementsAllRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[AccountingBankFeedStatementsAllResponse](../../Models/Requests/AccountingBankFeedStatementsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Create

Create Bank Feed Statement

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.bankFeedStatementsAdd" method="post" path="/accounting/bank-feed-statements" -->
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

AccountingBankFeedStatementsAddRequest req = new AccountingBankFeedStatementsAddRequest() {
    ServiceId = "salesforce",
    BankFeedStatement = new BankFeedStatementInput() {
        BankFeedAccountId = "acc_456",
        Status = StatementStatus.Pending,
        StartDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        EndDate = System.DateTime.Parse("2025-01-31T12:00:00.000Z"),
        StartBalance = 10500.25D,
        StartBalanceCreditOrDebit = CreditOrDebit.Debit,
        EndBalance = 9800.5D,
        EndBalanceCreditOrDebit = CreditOrDebit.Debit,
        Transactions = new List<Transactions>() {
            new Transactions() {
                PostedDate = System.DateTime.Parse("2025-01-15T12:00:00.000Z"),
                Description = "Payment received from ACME Corp",
                Amount = 250D,
                CreditOrDebit = CreditOrDebit.Debit,
                SourceTransactionId = "txn_987",
                Counterparty = "ACME Corp",
                Reference = "INV-2025-01",
                TransactionType = BankFeedStatementTransactionType.Payment,
            },
            new Transactions() {
                PostedDate = System.DateTime.Parse("2025-01-15T12:00:00.000Z"),
                Description = "Payment received from ACME Corp",
                Amount = 250D,
                CreditOrDebit = CreditOrDebit.Debit,
                SourceTransactionId = "txn_987",
                Counterparty = "ACME Corp",
                Reference = "INV-2025-01",
                TransactionType = BankFeedStatementTransactionType.Payment,
            },
            new Transactions() {
                PostedDate = System.DateTime.Parse("2025-01-15T12:00:00.000Z"),
                Description = "Payment received from ACME Corp",
                Amount = 250D,
                CreditOrDebit = CreditOrDebit.Debit,
                SourceTransactionId = "txn_987",
                Counterparty = "ACME Corp",
                Reference = "INV-2025-01",
                TransactionType = BankFeedStatementTransactionType.Payment,
            },
        },
    },
};

var res = await sdk.Accounting.BankFeedStatements.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [AccountingBankFeedStatementsAddRequest](../../Models/Requests/AccountingBankFeedStatementsAddRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[AccountingBankFeedStatementsAddResponse](../../Models/Requests/AccountingBankFeedStatementsAddResponse.md)**

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

Get Bank Feed Statement

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.bankFeedStatementsOne" method="get" path="/accounting/bank-feed-statements/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingBankFeedStatementsOneRequest req = new AccountingBankFeedStatementsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.BankFeedStatements.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [AccountingBankFeedStatementsOneRequest](../../Models/Requests/AccountingBankFeedStatementsOneRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[AccountingBankFeedStatementsOneResponse](../../Models/Requests/AccountingBankFeedStatementsOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Update

Update Bank Feed Statement

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.bankFeedStatementsUpdate" method="patch" path="/accounting/bank-feed-statements/{id}" -->
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

AccountingBankFeedStatementsUpdateRequest req = new AccountingBankFeedStatementsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    BankFeedStatement = new BankFeedStatementInput() {
        BankFeedAccountId = "acc_456",
        Status = StatementStatus.Pending,
        StartDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        EndDate = System.DateTime.Parse("2025-01-31T12:00:00.000Z"),
        StartBalance = 10500.25D,
        StartBalanceCreditOrDebit = CreditOrDebit.Debit,
        EndBalance = 9800.5D,
        EndBalanceCreditOrDebit = CreditOrDebit.Debit,
        Transactions = new List<Transactions>() {
            new Transactions() {
                PostedDate = System.DateTime.Parse("2025-01-15T12:00:00.000Z"),
                Description = "Payment received from ACME Corp",
                Amount = 250D,
                CreditOrDebit = CreditOrDebit.Debit,
                SourceTransactionId = "txn_987",
                Counterparty = "ACME Corp",
                Reference = "INV-2025-01",
                TransactionType = BankFeedStatementTransactionType.Payment,
            },
            new Transactions() {
                PostedDate = System.DateTime.Parse("2025-01-15T12:00:00.000Z"),
                Description = "Payment received from ACME Corp",
                Amount = 250D,
                CreditOrDebit = CreditOrDebit.Debit,
                SourceTransactionId = "txn_987",
                Counterparty = "ACME Corp",
                Reference = "INV-2025-01",
                TransactionType = BankFeedStatementTransactionType.Payment,
            },
        },
    },
};

var res = await sdk.Accounting.BankFeedStatements.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [AccountingBankFeedStatementsUpdateRequest](../../Models/Requests/AccountingBankFeedStatementsUpdateRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |

### Response

**[AccountingBankFeedStatementsUpdateResponse](../../Models/Requests/AccountingBankFeedStatementsUpdateResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Delete

Delete Bank Feed Statement

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.bankFeedStatementsDelete" method="delete" path="/accounting/bank-feed-statements/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingBankFeedStatementsDeleteRequest req = new AccountingBankFeedStatementsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.BankFeedStatements.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [AccountingBankFeedStatementsDeleteRequest](../../Models/Requests/AccountingBankFeedStatementsDeleteRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |

### Response

**[AccountingBankFeedStatementsDeleteResponse](../../Models/Requests/AccountingBankFeedStatementsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |