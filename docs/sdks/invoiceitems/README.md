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

AccountingInvoiceItemsAllRequest req = new AccountingInvoiceItemsAllRequest() {
    ServiceId = "salesforce",
    Filter = new InvoiceItemsFilter() {
        Name = "Widgets Large",
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.InvoiceItems.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingInvoiceItemsAllRequest](../../Models/Requests/AccountingInvoiceItemsAllRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingInvoiceItemsAllResponse](../../Models/Requests/AccountingInvoiceItemsAllResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Create

Create Invoice Item

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingInvoiceItemsAddRequest req = new AccountingInvoiceItemsAddRequest() {
    InvoiceItem = new InvoiceItemInput() {
        Name = "Model Y",
        Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
        Code = "120-C",
        Sold = true,
        Purchased = true,
        Tracked = true,
        Taxable = true,
        InventoryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        Type = Unify.Models.Components.InvoiceItemType.Inventory,
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
        TrackingCategories = new List<LinkedTrackingCategory>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        Active = true,
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

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Get

Get Invoice Item

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingInvoiceItemsOneRequest req = new AccountingInvoiceItemsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
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

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Update

Update Invoice Item

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingInvoiceItemsUpdateRequest req = new AccountingInvoiceItemsUpdateRequest() {
    Id = "<id>",
    InvoiceItem = new InvoiceItemInput() {
        Name = "Model Y",
        Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
        Code = "120-C",
        Sold = true,
        Purchased = true,
        Tracked = true,
        Taxable = true,
        InventoryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        Type = Unify.Models.Components.InvoiceItemType.Inventory,
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
        TrackingCategories = new List<LinkedTrackingCategory>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        Active = true,
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

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Delete

Delete Invoice Item

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
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

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |