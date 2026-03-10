# Accounting.ExpenseReports

## Overview

### Available Operations

* [List](#list) - List Expense Reports
* [Create](#create) - Create Expense Report
* [Get](#get) - Get Expense Report
* [Update](#update) - Update Expense Report
* [Delete](#delete) - Delete Expense Report

## List

List Expense Reports

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseReportsAll" method="get" path="/accounting/expense-reports" -->
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

AccountingExpenseReportsAllRequest req = new AccountingExpenseReportsAllRequest() {
    ServiceId = "salesforce",
    Fields = "id,updated_at",
    Filter = new ExpenseReportsFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        Status = ExpenseReportsFilterStatus.Submitted,
    },
};

AccountingExpenseReportsAllResponse? res = await sdk.Accounting.ExpenseReports.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingExpenseReportsAllRequest](../../Models/Requests/AccountingExpenseReportsAllRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingExpenseReportsAllResponse](../../Models/Requests/AccountingExpenseReportsAllResponse.md)**

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

Create Expense Report

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseReportsAdd" method="post" path="/accounting/expense-reports" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseReportsAddRequest req = new AccountingExpenseReportsAddRequest() {
    ServiceId = "salesforce",
    ExpenseReport = new ExpenseReportInput() {
        DisplayId = "123456",
        Number = "ER-001",
        Title = "Q1 Business Travel",
        Employee = new ExpenseReportEmployee() {
            Id = "12345",
            DisplayName = "John Doe",
        },
        Status = ExpenseReportStatus.Submitted,
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        PostingDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-06-01")),
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-06-15")),
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        SubTotal = 250D,
        TotalTax = 25D,
        TotalAmount = 1250.75D,
        ReimbursableAmount = 1100D,
        Memo = "Business travel expenses for Q1 client meetings",
        Department = new LinkedDepartmentInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        Location = new LinkedLocationInput() {
            Id = "123456",
            DisplayId = "123456",
            Name = "New York Office",
        },
        Account = null,
        AccountingPeriod = new AccountingPeriod() {
            Id = "12345",
            Name = "Q1 2024",
        },
        LineItems = new List<ExpenseReportLineItemInput>() {},
        Subsidiary = new LinkedSubsidiaryInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Code = "100",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        TaxInclusive = true,
        ApprovedBy = new ApprovedBy() {
            Id = "12345",
            DisplayName = "Jane Smith",
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateStr(
                    "Uses Salesforce and Marketo"
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
};

var res = await sdk.Accounting.ExpenseReports.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingExpenseReportsAddRequest](../../Models/Requests/AccountingExpenseReportsAddRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingExpenseReportsAddResponse](../../Models/Requests/AccountingExpenseReportsAddResponse.md)**

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

Get Expense Report

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseReportsOne" method="get" path="/accounting/expense-reports/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseReportsOneRequest req = new AccountingExpenseReportsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.ExpenseReports.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingExpenseReportsOneRequest](../../Models/Requests/AccountingExpenseReportsOneRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingExpenseReportsOneResponse](../../Models/Requests/AccountingExpenseReportsOneResponse.md)**

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

Update Expense Report

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseReportsUpdate" method="patch" path="/accounting/expense-reports/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseReportsUpdateRequest req = new AccountingExpenseReportsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    ExpenseReport = new ExpenseReportInput() {
        DisplayId = "123456",
        Number = "ER-001",
        Title = "Q1 Business Travel",
        Employee = new ExpenseReportEmployee() {
            Id = "12345",
            DisplayName = "John Doe",
        },
        Status = ExpenseReportStatus.Submitted,
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        PostingDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-06-01")),
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-06-15")),
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        SubTotal = 250D,
        TotalTax = 25D,
        TotalAmount = 1250.75D,
        ReimbursableAmount = 1100D,
        Memo = "Business travel expenses for Q1 client meetings",
        Department = new LinkedDepartmentInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        Location = new LinkedLocationInput() {
            Id = "123456",
            DisplayId = "123456",
            Name = "New York Office",
        },
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        AccountingPeriod = new AccountingPeriod() {
            Id = "12345",
            Name = "Q1 2024",
        },
        LineItems = new List<ExpenseReportLineItemInput>() {},
        Subsidiary = new LinkedSubsidiaryInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        TrackingCategories = null,
        TaxInclusive = true,
        ApprovedBy = new ApprovedBy() {
            Id = "12345",
            DisplayName = "Jane Smith",
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateStr(
                    "Uses Salesforce and Marketo"
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
};

var res = await sdk.Accounting.ExpenseReports.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingExpenseReportsUpdateRequest](../../Models/Requests/AccountingExpenseReportsUpdateRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingExpenseReportsUpdateResponse](../../Models/Requests/AccountingExpenseReportsUpdateResponse.md)**

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

Delete Expense Report

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.expenseReportsDelete" method="delete" path="/accounting/expense-reports/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingExpenseReportsDeleteRequest req = new AccountingExpenseReportsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.ExpenseReports.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingExpenseReportsDeleteRequest](../../Models/Requests/AccountingExpenseReportsDeleteRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingExpenseReportsDeleteResponse](../../Models/Requests/AccountingExpenseReportsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |