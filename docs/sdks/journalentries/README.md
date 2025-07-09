# JournalEntries
(*Accounting.JournalEntries*)

## Overview

### Available Operations

* [List](#list) - List Journal Entries
* [Create](#create) - Create Journal Entry
* [Get](#get) - Get Journal Entry
* [Update](#update) - Update Journal Entry
* [Delete](#delete) - Delete Journal Entry

## List

List Journal Entries

### Example Usage

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

AccountingJournalEntriesAllRequest req = new AccountingJournalEntriesAllRequest() {
    ServiceId = "salesforce",
    Filter = new JournalEntriesFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
    },
    Sort = new JournalEntriesSort() {
        By = JournalEntriesSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingJournalEntriesAllResponse? res = await sdk.Accounting.JournalEntries.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingJournalEntriesAllRequest](../../Models/Requests/AccountingJournalEntriesAllRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingJournalEntriesAllResponse](../../Models/Requests/AccountingJournalEntriesAllResponse.md)**

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

Create Journal Entry

### Example Usage

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

AccountingJournalEntriesAddRequest req = new AccountingJournalEntriesAddRequest() {
    ServiceId = "salesforce",
    JournalEntry = new JournalEntryInput() {
        Title = "Purchase Invoice-Inventory (USD): 2019/02/01 Batch Summary Entry",
        CurrencyRate = 0.69D,
        Currency = Currency.Usd,
        CompanyId = "12345",
        LineItems = new List<JournalEntryLineItemInput>() {
            new JournalEntryLineItemInput() {
                Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
                TaxAmount = 27500D,
                SubTotal = 27500D,
                TotalAmount = 27500D,
                Type = JournalEntryLineItemType.Debit,
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
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
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                },
                LedgerAccount = new LinkedLedgerAccountInput() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
                },
                Customer = new LinkedCustomerInput() {
                    Id = "12345",
                    DisplayName = "Windsurf Shop",
                    Email = "boring@boring.com",
                },
                Supplier = new LinkedSupplierInput() {
                    Id = "12345",
                    DisplayName = "Windsurf Shop",
                    Address = new Address() {
                        Id = "123",
                        Type = ApideckUnifySdk.Models.Components.Type.Primary,
                        String = "25 Spring Street, Blackburn, VIC 3130",
                        Name = "HQ US",
                        Line1 = "Main street",
                        Line2 = "apt #",
                        Line3 = "Suite #",
                        Line4 = "delivery instructions",
                        StreetNumber = "25",
                        City = "San Francisco",
                        State = "CA",
                        PostalCode = "94104",
                        Country = "US",
                        Latitude = "40.759211",
                        Longitude = "-73.984638",
                        County = "Santa Clara",
                        ContactName = "Elon Musk",
                        Salutation = "Mr",
                        PhoneNumber = "111-111-1111",
                        Fax = "122-111-1111",
                        Email = "elon@musk.com",
                        Website = "https://elonmusk.com",
                        Notes = "Address notes or delivery instructions.",
                        RowVersion = "1-12345",
                    },
                },
                DepartmentId = "12345",
                LocationId = "12345",
                LineNumber = 1,
            },
        },
        Status = JournalEntryStatus.Draft,
        Memo = "Thank you for your business and have a great day!",
        PostedAt = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        JournalSymbol = "IND",
        TaxType = "sales",
        TaxCode = "1234",
        Number = "OIT00546",
        TrackingCategories = null,
        AccountingPeriod = "01-24",
        RowVersion = "1-12345",
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

var res = await sdk.Accounting.JournalEntries.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingJournalEntriesAddRequest](../../Models/Requests/AccountingJournalEntriesAddRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingJournalEntriesAddResponse](../../Models/Requests/AccountingJournalEntriesAddResponse.md)**

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

Get Journal Entry

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingJournalEntriesOneRequest req = new AccountingJournalEntriesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.JournalEntries.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingJournalEntriesOneRequest](../../Models/Requests/AccountingJournalEntriesOneRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingJournalEntriesOneResponse](../../Models/Requests/AccountingJournalEntriesOneResponse.md)**

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

Update Journal Entry

### Example Usage

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

AccountingJournalEntriesUpdateRequest req = new AccountingJournalEntriesUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    JournalEntry = new JournalEntryInput() {
        Title = "Purchase Invoice-Inventory (USD): 2019/02/01 Batch Summary Entry",
        CurrencyRate = 0.69D,
        Currency = Currency.Usd,
        CompanyId = "12345",
        LineItems = new List<JournalEntryLineItemInput>() {
            new JournalEntryLineItemInput() {
                Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
                TaxAmount = 27500D,
                SubTotal = 27500D,
                TotalAmount = 27500D,
                Type = JournalEntryLineItemType.Debit,
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
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
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                },
                LedgerAccount = new LinkedLedgerAccountInput() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
                },
                Customer = new LinkedCustomerInput() {
                    Id = "12345",
                    DisplayName = "Windsurf Shop",
                    Email = "boring@boring.com",
                },
                Supplier = new LinkedSupplierInput() {
                    Id = "12345",
                    DisplayName = "Windsurf Shop",
                    Address = new Address() {
                        Id = "123",
                        Type = ApideckUnifySdk.Models.Components.Type.Primary,
                        String = "25 Spring Street, Blackburn, VIC 3130",
                        Name = "HQ US",
                        Line1 = "Main street",
                        Line2 = "apt #",
                        Line3 = "Suite #",
                        Line4 = "delivery instructions",
                        StreetNumber = "25",
                        City = "San Francisco",
                        State = "CA",
                        PostalCode = "94104",
                        Country = "US",
                        Latitude = "40.759211",
                        Longitude = "-73.984638",
                        County = "Santa Clara",
                        ContactName = "Elon Musk",
                        Salutation = "Mr",
                        PhoneNumber = "111-111-1111",
                        Fax = "122-111-1111",
                        Email = "elon@musk.com",
                        Website = "https://elonmusk.com",
                        Notes = "Address notes or delivery instructions.",
                        RowVersion = "1-12345",
                    },
                },
                DepartmentId = "12345",
                LocationId = "12345",
                LineNumber = 1,
            },
        },
        Status = JournalEntryStatus.Draft,
        Memo = "Thank you for your business and have a great day!",
        PostedAt = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        JournalSymbol = "IND",
        TaxType = "sales",
        TaxCode = "1234",
        Number = "OIT00546",
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
        AccountingPeriod = "01-24",
        RowVersion = "1-12345",
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

var res = await sdk.Accounting.JournalEntries.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingJournalEntriesUpdateRequest](../../Models/Requests/AccountingJournalEntriesUpdateRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingJournalEntriesUpdateResponse](../../Models/Requests/AccountingJournalEntriesUpdateResponse.md)**

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

Delete Journal Entry

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingJournalEntriesDeleteRequest req = new AccountingJournalEntriesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.JournalEntries.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingJournalEntriesDeleteRequest](../../Models/Requests/AccountingJournalEntriesDeleteRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingJournalEntriesDeleteResponse](../../Models/Requests/AccountingJournalEntriesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |