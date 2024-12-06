# Expenses
(*Accounting.Expenses*)

## Overview

### Available Operations

* [List](#list) - List Expenses
* [Create](#create) - Create Expense
* [Get](#get) - Get Expense
* [Update](#update) - Update Expense
* [Delete](#delete) - Delete Expense

## List

List Expenses

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

AccountingExpensesAllRequest req = new AccountingExpensesAllRequest() {
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Expenses.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingExpensesAllRequest](../../Models/Requests/AccountingExpensesAllRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingExpensesAllResponse](../../Models/Requests/AccountingExpensesAllResponse.md)**

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

Create Expense

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingExpensesAddRequest req = new AccountingExpensesAddRequest() {
    Expense = new ExpenseInput() {
        Number = "OIT00546",
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        AccountId = "123456",
        CustomerId = "12345",
        SupplierId = "12345",
        CompanyId = "12345",
        DepartmentId = "12345",
        PaymentType = ApideckUnifySdk.Models.Components.ExpensePaymentType.Cash,
        Currency = ApideckUnifySdk.Models.Components.Currency.Usd,
        CurrencyRate = 0.69D,
        Type = ApideckUnifySdk.Models.Components.ExpenseType.Expense,
        Memo = "For travel expenses incurred on 2024-05-15",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TotalAmount = 275D,
        LineItems = new List<ExpenseLineItemInput>() {
            new ExpenseLineItemInput() {
                TrackingCategories = new List<LinkedTrackingCategory>() {
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                },
                AccountId = "123456",
                CustomerId = "12345",
                DepartmentId = "12345",
                LocationId = "12345",
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
                },
                Description = "Travel US.",
                TotalAmount = 275D,
                Billable = true,
            },
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateBoolean(
                    true
                ),
            },
        },
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
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Expenses.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingExpensesAddRequest](../../Models/Requests/AccountingExpensesAddRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingExpensesAddResponse](../../Models/Requests/AccountingExpensesAddResponse.md)**

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

Get Expense

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

AccountingExpensesOneRequest req = new AccountingExpensesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Expenses.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingExpensesOneRequest](../../Models/Requests/AccountingExpensesOneRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingExpensesOneResponse](../../Models/Requests/AccountingExpensesOneResponse.md)**

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

Update Expense

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingExpensesUpdateRequest req = new AccountingExpensesUpdateRequest() {
    Id = "<id>",
    Expense = new ExpenseInput() {
        Number = "OIT00546",
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        AccountId = "123456",
        CustomerId = "12345",
        SupplierId = "12345",
        CompanyId = "12345",
        DepartmentId = "12345",
        PaymentType = ApideckUnifySdk.Models.Components.ExpensePaymentType.Cash,
        Currency = ApideckUnifySdk.Models.Components.Currency.Usd,
        CurrencyRate = 0.69D,
        Type = ApideckUnifySdk.Models.Components.ExpenseType.Expense,
        Memo = "For travel expenses incurred on 2024-05-15",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TotalAmount = 275D,
        LineItems = new List<ExpenseLineItemInput>() {
            new ExpenseLineItemInput() {
                TrackingCategories = new List<LinkedTrackingCategory>() {
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                },
                AccountId = "123456",
                CustomerId = "12345",
                DepartmentId = "12345",
                LocationId = "12345",
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
                },
                Description = "Travel US.",
                TotalAmount = 275D,
                Billable = true,
            },
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateArrayOf6(
                    new List<Six>() {
                        new Six() {},
                    }
                ),
            },
        },
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
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Expenses.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingExpensesUpdateRequest](../../Models/Requests/AccountingExpensesUpdateRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingExpensesUpdateResponse](../../Models/Requests/AccountingExpensesUpdateResponse.md)**

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

Delete Expense

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

AccountingExpensesDeleteRequest req = new AccountingExpensesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Expenses.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingExpensesDeleteRequest](../../Models/Requests/AccountingExpensesDeleteRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingExpensesDeleteResponse](../../Models/Requests/AccountingExpensesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |