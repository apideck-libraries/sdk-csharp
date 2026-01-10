# Accounting.Expenses

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

<!-- UsageSnippet language="csharp" operationID="accounting.expensesAll" method="get" path="/accounting/expenses" -->
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

AccountingExpensesAllRequest req = new AccountingExpensesAllRequest() {
    ServiceId = "salesforce",
    Filter = new ExpensesFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        Status = ExpensesFilterStatus.Draft,
        Type = ExpensesFilterType.Expense,
    },
};

AccountingExpensesAllResponse? res = await sdk.Accounting.Expenses.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
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

<!-- UsageSnippet language="csharp" operationID="accounting.expensesAdd" method="post" path="/accounting/expenses" -->
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

AccountingExpensesAddRequest req = new AccountingExpensesAddRequest() {
    ServiceId = "salesforce",
    Expense = new ExpenseInput() {
        Number = "OIT00546",
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        AccountId = "123456",
        SupplierId = "12345",
        CompanyId = "12345",
        DepartmentId = "12345",
        PaymentType = ExpensePaymentType.Cash,
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        Type = ExpenseType.Expense,
        Memo = "For travel expenses incurred on 2024-05-15",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TotalAmount = 275D,
        LineItems = new List<ExpenseLineItemInput>() {
            new ExpenseLineItemInput() {
                TrackingCategories = new List<LinkedTrackingCategory?>() {
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
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
                LineNumber = 1,
            },
        },
        CustomFields = new List<CustomField>() {
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = CustomField1Value.CreateStr(
                        "Uses Salesforce and Marketo"
                    ),
                }
            ),
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = CustomField1Value.CreateStr(
                        "Uses Salesforce and Marketo"
                    ),
                }
            ),
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = CustomField1Value.CreateStr(
                        "Uses Salesforce and Marketo"
                    ),
                }
            ),
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
                    new ExtendPaths() {
                        Path = "$.nested.property",
                        Value = new Dictionary<string, object>() {
                            { "TaxClassificationRef", new Dictionary<string, object>() {
                                { "value", "EUC-99990201-V1-00020000" },
                            } },
                        },
                    },
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
                    new ExtendPaths() {
                        Path = "$.nested.property",
                        Value = new Dictionary<string, object>() {
                            { "TaxClassificationRef", new Dictionary<string, object>() {
                                { "value", "EUC-99990201-V1-00020000" },
                            } },
                        },
                    },
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

<!-- UsageSnippet language="csharp" operationID="accounting.expensesOne" method="get" path="/accounting/expenses/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
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

<!-- UsageSnippet language="csharp" operationID="accounting.expensesUpdate" method="patch" path="/accounting/expenses/{id}" -->
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

AccountingExpensesUpdateRequest req = new AccountingExpensesUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Expense = new ExpenseInput() {
        Number = "OIT00546",
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        AccountId = "123456",
        SupplierId = "12345",
        CompanyId = "12345",
        DepartmentId = "12345",
        PaymentType = ExpensePaymentType.Cash,
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        Type = ExpenseType.Expense,
        Memo = "For travel expenses incurred on 2024-05-15",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TotalAmount = 275D,
        LineItems = new List<ExpenseLineItemInput>() {
            new ExpenseLineItemInput() {
                TrackingCategories = new List<LinkedTrackingCategory?>() {
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
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
                LineNumber = 1,
            },
        },
        CustomFields = new List<CustomField>() {
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = CustomField1Value.CreateStr(
                        "Uses Salesforce and Marketo"
                    ),
                }
            ),
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

<!-- UsageSnippet language="csharp" operationID="accounting.expensesDelete" method="delete" path="/accounting/expenses/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
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