# InvoiceItems
(*Accounting.InvoiceItems*)

## Overview

### Available Operations

* [List](#list) - List Invoice Items
* [Create](#create) - Create Invoice Item
* [Get](#get) - Get Invoice Item
* [Update](#update) - Update Invoice Item
* [Delete](#delete) - Delete Invoice Item

## List

List Invoice Items

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoiceItemsAll" method="get" path="/accounting/invoice-items" -->
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

AccountingInvoiceItemsAllRequest req = new AccountingInvoiceItemsAllRequest() {
    ServiceId = "salesforce",
    Filter = new InvoiceItemsFilter() {
        Name = "Widgets Large",
        Type = InvoiceItemType.Service,
    },
    Sort = new InvoiceItemsSort() {
        By = InvoiceItemsSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingInvoiceItemsAllResponse? res = await sdk.Accounting.InvoiceItems.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingInvoiceItemsAllRequest](../../Models/Requests/AccountingInvoiceItemsAllRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingInvoiceItemsAllResponse](../../Models/Requests/AccountingInvoiceItemsAllResponse.md)**

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

Create Invoice Item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoiceItemsAdd" method="post" path="/accounting/invoice-items" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingInvoiceItemsAddRequest req = new AccountingInvoiceItemsAddRequest() {
    ServiceId = "salesforce",
    InvoiceItem = new InvoiceItemInput() {
        Name = "Model Y",
        Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
        Code = "120-C",
        Sold = true,
        Purchased = true,
        Tracked = true,
        Taxable = true,
        InventoryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        Type = InvoiceItemTypeType.Inventory,
        SalesDetails = new InvoiceItemSalesDetails() {
            UnitPrice = 27500.5D,
            UnitOfMeasure = "pc.",
            TaxInclusive = true,
            TaxRate = new LinkedTaxRateInput() {
                Id = "123456",
                Rate = 10D,
            },
        },
        PurchaseDetails = new InvoiceItemPurchaseDetails() {
            UnitPrice = 27500.5D,
            UnitOfMeasure = "pc.",
            TaxInclusive = true,
            TaxRate = new LinkedTaxRateInput() {
                Id = "123456",
                Rate = 10D,
            },
        },
        Quantity = 1D,
        UnitPrice = 27500.5D,
        AssetAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        IncomeAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        ExpenseAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        TrackingCategories = null,
        Active = true,
        DepartmentId = "12345",
        LocationId = "12345",
        SubsidiaryId = "12345",
        TaxScheduleId = "123456",
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
                },
            },
        },
    },
};

var res = await sdk.Accounting.InvoiceItems.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingInvoiceItemsAddRequest](../../Models/Requests/AccountingInvoiceItemsAddRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingInvoiceItemsAddResponse](../../Models/Requests/AccountingInvoiceItemsAddResponse.md)**

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

Get Invoice Item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoiceItemsOne" method="get" path="/accounting/invoice-items/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingInvoiceItemsOneRequest req = new AccountingInvoiceItemsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
    Filter = new InvoiceItemFilter() {
        Type = InvoiceItemFilterInvoiceItemType.Service,
    },
};

var res = await sdk.Accounting.InvoiceItems.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingInvoiceItemsOneRequest](../../Models/Requests/AccountingInvoiceItemsOneRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingInvoiceItemsOneResponse](../../Models/Requests/AccountingInvoiceItemsOneResponse.md)**

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

Update Invoice Item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoiceItemsUpdate" method="patch" path="/accounting/invoice-items/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingInvoiceItemsUpdateRequest req = new AccountingInvoiceItemsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    InvoiceItem = new InvoiceItemInput() {
        Name = "Model Y",
        Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
        Code = "120-C",
        Sold = true,
        Purchased = true,
        Tracked = true,
        Taxable = true,
        InventoryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        Type = InvoiceItemTypeType.Inventory,
        SalesDetails = new InvoiceItemSalesDetails() {
            UnitPrice = 27500.5D,
            UnitOfMeasure = "pc.",
            TaxInclusive = true,
            TaxRate = new LinkedTaxRateInput() {
                Id = "123456",
                Rate = 10D,
            },
        },
        PurchaseDetails = new InvoiceItemPurchaseDetails() {
            UnitPrice = 27500.5D,
            UnitOfMeasure = "pc.",
            TaxInclusive = true,
            TaxRate = new LinkedTaxRateInput() {
                Id = "123456",
                Rate = 10D,
            },
        },
        Quantity = 1D,
        UnitPrice = 27500.5D,
        AssetAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        IncomeAccount = null,
        ExpenseAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        Active = true,
        DepartmentId = "12345",
        LocationId = "12345",
        SubsidiaryId = "12345",
        TaxScheduleId = "123456",
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
        },
    },
};

var res = await sdk.Accounting.InvoiceItems.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [AccountingInvoiceItemsUpdateRequest](../../Models/Requests/AccountingInvoiceItemsUpdateRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[AccountingInvoiceItemsUpdateResponse](../../Models/Requests/AccountingInvoiceItemsUpdateResponse.md)**

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

Delete Invoice Item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoiceItemsDelete" method="delete" path="/accounting/invoice-items/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingInvoiceItemsDeleteRequest req = new AccountingInvoiceItemsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.InvoiceItems.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [AccountingInvoiceItemsDeleteRequest](../../Models/Requests/AccountingInvoiceItemsDeleteRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[AccountingInvoiceItemsDeleteResponse](../../Models/Requests/AccountingInvoiceItemsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |