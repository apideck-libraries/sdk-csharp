# Accounting.ExpenseCategories

## Overview

### Available Operations

* [List](#list) - List Expense Categories
* [Create](#create) - Create Expense Category
* [Get](#get) - Get Expense Category
* [Update](#update) - Update Expense Category
* [Delete](#delete) - Delete Expense Category

## List

List Expense Categories

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseCategoriesAll" method="get" path="/accounting/expense-categories" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseCategoriesAllRequest req = new AccountingExpenseCategoriesAllRequest() {
    ServiceId = "salesforce",
    Fields = "id,updated_at",
    Filter = new ExpenseCategoriesFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        Status = ExpenseCategoriesFilterStatus.Active,
    },
};

AccountingExpenseCategoriesAllResponse? res = await sdk.Accounting.ExpenseCategories.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingExpenseCategoriesAllRequest](../../Models/Requests/AccountingExpenseCategoriesAllRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingExpenseCategoriesAllResponse](../../Models/Requests/AccountingExpenseCategoriesAllResponse.md)**

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

Create Expense Category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseCategoriesAdd" method="post" path="/accounting/expense-categories" -->
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

AccountingExpenseCategoriesAddRequest req = new AccountingExpenseCategoriesAddRequest() {
    ServiceId = "salesforce",
    ExpenseCategory = new ExpenseCategoryInput() {
        DisplayId = "123456",
        Name = "Travel",
        Code = "TRAVEL-001",
        Description = "Travel-related expenses including flights, hotels, and ground transportation.",
        Status = ExpenseCategoryStatus.Active,
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        OffsetAccount = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Code = "N-T",
            Rate = 10D,
        },
        RateRequired = false,
        DefaultRate = 0.67D,
        RowVersion = "1-12345",
        PassThrough = new List<PassThroughBody>() {
            new PassThroughBody() {
                ServiceId = "<id>",
                ExtendPaths = new List<ExtendPaths>() {
                    new ExtendPaths() {
                        Path = "$.nested.property",
                        Value = new Dictionary<string, object>() {
                            { "TaxClassificationRef", new Dictionary<string, object>() {
                                { "value", "EUC-99990201-V1-00020000" },
                            } },
                        },
                    },
                },
            },
        },
    },
};

var res = await sdk.Accounting.ExpenseCategories.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingExpenseCategoriesAddRequest](../../Models/Requests/AccountingExpenseCategoriesAddRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingExpenseCategoriesAddResponse](../../Models/Requests/AccountingExpenseCategoriesAddResponse.md)**

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

Get Expense Category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseCategoriesOne" method="get" path="/accounting/expense-categories/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseCategoriesOneRequest req = new AccountingExpenseCategoriesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.ExpenseCategories.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingExpenseCategoriesOneRequest](../../Models/Requests/AccountingExpenseCategoriesOneRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingExpenseCategoriesOneResponse](../../Models/Requests/AccountingExpenseCategoriesOneResponse.md)**

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

Update Expense Category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseCategoriesUpdate" method="patch" path="/accounting/expense-categories/{id}" -->
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

AccountingExpenseCategoriesUpdateRequest req = new AccountingExpenseCategoriesUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    ExpenseCategory = new ExpenseCategoryInput() {
        DisplayId = "123456",
        Name = "Travel",
        Code = "TRAVEL-001",
        Description = "Travel-related expenses including flights, hotels, and ground transportation.",
        Status = ExpenseCategoryStatus.Active,
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        OffsetAccount = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Code = "N-T",
            Rate = 10D,
        },
        RateRequired = false,
        DefaultRate = 0.67D,
        RowVersion = "1-12345",
        PassThrough = new List<PassThroughBody>() {
            new PassThroughBody() {
                ServiceId = "<id>",
                ExtendPaths = new List<ExtendPaths>() {
                    new ExtendPaths() {
                        Path = "$.nested.property",
                        Value = new Dictionary<string, object>() {
                            { "TaxClassificationRef", new Dictionary<string, object>() {
                                { "value", "EUC-99990201-V1-00020000" },
                            } },
                        },
                    },
                },
            },
        },
    },
};

var res = await sdk.Accounting.ExpenseCategories.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [AccountingExpenseCategoriesUpdateRequest](../../Models/Requests/AccountingExpenseCategoriesUpdateRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[AccountingExpenseCategoriesUpdateResponse](../../Models/Requests/AccountingExpenseCategoriesUpdateResponse.md)**

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

Delete Expense Category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseCategoriesDelete" method="delete" path="/accounting/expense-categories/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseCategoriesDeleteRequest req = new AccountingExpenseCategoriesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.ExpenseCategories.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [AccountingExpenseCategoriesDeleteRequest](../../Models/Requests/AccountingExpenseCategoriesDeleteRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[AccountingExpenseCategoriesDeleteResponse](../../Models/Requests/AccountingExpenseCategoriesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |