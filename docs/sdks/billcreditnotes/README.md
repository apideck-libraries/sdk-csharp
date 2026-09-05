# Accounting.BillCreditNotes

## Overview

### Available Operations

* [List](#list) - List Bill Credit Notes
* [Create](#create) - Create Bill Credit Note
* [Get](#get) - Get Bill Credit Note
* [Update](#update) - Update Bill Credit Note
* [Delete](#delete) - Delete Bill Credit Note

## List

List Bill Credit Notes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.billCreditNotesAll" method="get" path="/accounting/bill-credit-notes" -->
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

AccountingBillCreditNotesAllRequest req = new AccountingBillCreditNotesAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Filter = new BillCreditNotesFilter() {
        Ids = "12345,67890",
        IdSince = "1",
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        CreatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        Number = "OIT00546",
        SupplierId = "123abc",
    },
    Sort = new BillCreditNotesSort() {
        By = BillCreditNotesSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingBillCreditNotesAllResponse? res = await sdk.Accounting.BillCreditNotes.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [AccountingBillCreditNotesAllRequest](../../Models/Requests/AccountingBillCreditNotesAllRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[AccountingBillCreditNotesAllResponse](../../Models/Requests/AccountingBillCreditNotesAllResponse.md)**

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

Create Bill Credit Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.billCreditNotesAdd" method="post" path="/accounting/bill-credit-notes" -->
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

AccountingBillCreditNotesAddRequest req = new AccountingBillCreditNotesAddRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    BillCreditNote = new BillCreditNoteInput() {
        Number = "OIT00546",
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
                Line5 = "Attention: Finance Dept",
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
        Subsidiary = new LinkedSubsidiaryInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        Location = new LinkedLocationInput() {
            Id = "123456",
            DisplayId = "123456",
            Name = "New York Office",
        },
        Department = new LinkedDepartmentInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 27500D,
        TotalAmount = 49.99D,
        TotalTax = 2500D,
        TaxCode = "1234",
        Balance = 27500D,
        RemainingCredit = 27500D,
        Status = BillCreditNoteStatus.Authorised,
        Reference = "123456",
        DateIssued = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        DatePaid = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        Type = BillCreditNoteType.AccountsPayableCredit,
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        LineItems = new List<BillCreditNoteLineItemInput>() {
            new BillCreditNoteLineItemInput() {
                RowId = "12345",
                Code = "120-C",
                LineNumber = 1,
                Description = "Returned goods credit",
                Type = LineItemType.ExpenseAccount,
                TaxAmount = 27.5D,
                TotalAmount = 27500D,
                Quantity = 1D,
                UnitPrice = 27500.5D,
                UnitOfMeasure = "pc.",
                DiscountPercentage = 0.01D,
                DiscountAmount = 19.99D,
                ServiceDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-01-15")),
                Location = new LinkedLocationInput() {
                    Id = "123456",
                    DisplayId = "123456",
                    Name = "New York Office",
                },
                Department = null,
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Code = "N-T",
                    Rate = 10D,
                },
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    Name = "Bank account",
                    NominalCode = "N091",
                    Code = "453",
                    ParentId = "123456",
                    DisplayId = "123456",
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
                RowVersion = "1-12345",
            },
        },
        Allocations = new List<AllocationInput>() {
            new AllocationInput() {
                Id = "123456",
                Amount = 49.99D,
                AllocationId = "123456",
            },
        },
        Note = "Some notes about this bill credit note",
        Terms = "Some terms about this bill credit note",
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Code = "100",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        CustomFields = new List<CustomField>() {
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    RefName = "Marketing",
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
        },
    },
};

var res = await sdk.Accounting.BillCreditNotes.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [AccountingBillCreditNotesAddRequest](../../Models/Requests/AccountingBillCreditNotesAddRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[AccountingBillCreditNotesAddResponse](../../Models/Requests/AccountingBillCreditNotesAddResponse.md)**

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

Get Bill Credit Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.billCreditNotesOne" method="get" path="/accounting/bill-credit-notes/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingBillCreditNotesOneRequest req = new AccountingBillCreditNotesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.BillCreditNotes.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [AccountingBillCreditNotesOneRequest](../../Models/Requests/AccountingBillCreditNotesOneRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[AccountingBillCreditNotesOneResponse](../../Models/Requests/AccountingBillCreditNotesOneResponse.md)**

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

Update Bill Credit Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.billCreditNotesUpdate" method="patch" path="/accounting/bill-credit-notes/{id}" -->
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

AccountingBillCreditNotesUpdateRequest req = new AccountingBillCreditNotesUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    BillCreditNote = new BillCreditNoteInput() {
        Number = "OIT00546",
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
                Line5 = "Attention: Finance Dept",
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
        Subsidiary = new LinkedSubsidiaryInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        Location = new LinkedLocationInput() {
            Id = "123456",
            DisplayId = "123456",
            Name = "New York Office",
        },
        Department = new LinkedDepartmentInput() {
            DisplayId = "123456",
            Name = "Acme Inc.",
        },
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 27500D,
        TotalAmount = 49.99D,
        TotalTax = 2500D,
        TaxCode = "1234",
        Balance = 27500D,
        RemainingCredit = 27500D,
        Status = BillCreditNoteStatus.Authorised,
        Reference = "123456",
        DateIssued = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        DatePaid = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        Type = BillCreditNoteType.AccountsPayableCredit,
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
        },
        LineItems = new List<BillCreditNoteLineItemInput>() {
            new BillCreditNoteLineItemInput() {
                RowId = "12345",
                Code = "120-C",
                LineNumber = 1,
                Description = "Returned goods credit",
                Type = LineItemType.ExpenseAccount,
                TaxAmount = 27.5D,
                TotalAmount = 27500D,
                Quantity = 1D,
                UnitPrice = 27500.5D,
                UnitOfMeasure = "pc.",
                DiscountPercentage = 0.01D,
                DiscountAmount = 19.99D,
                ServiceDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-01-15")),
                Location = new LinkedLocationInput() {
                    Id = "123456",
                    DisplayId = "123456",
                    Name = "New York Office",
                },
                Department = new LinkedDepartmentInput() {
                    DisplayId = "123456",
                    Name = "Acme Inc.",
                },
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Code = "N-T",
                    Rate = 10D,
                },
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    Name = "Bank account",
                    NominalCode = "N091",
                    Code = "453",
                    ParentId = "123456",
                    DisplayId = "123456",
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
                RowVersion = "1-12345",
            },
        },
        Allocations = new List<AllocationInput>() {
            new AllocationInput() {
                Id = "123456",
                Amount = 49.99D,
                AllocationId = "123456",
            },
        },
        Note = "Some notes about this bill credit note",
        Terms = "Some terms about this bill credit note",
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Code = "100",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        CustomFields = new List<CustomField>() {
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    RefName = "Marketing",
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
        },
    },
};

var res = await sdk.Accounting.BillCreditNotes.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [AccountingBillCreditNotesUpdateRequest](../../Models/Requests/AccountingBillCreditNotesUpdateRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[AccountingBillCreditNotesUpdateResponse](../../Models/Requests/AccountingBillCreditNotesUpdateResponse.md)**

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

Delete Bill Credit Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.billCreditNotesDelete" method="delete" path="/accounting/bill-credit-notes/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingBillCreditNotesDeleteRequest req = new AccountingBillCreditNotesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.BillCreditNotes.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [AccountingBillCreditNotesDeleteRequest](../../Models/Requests/AccountingBillCreditNotesDeleteRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[AccountingBillCreditNotesDeleteResponse](../../Models/Requests/AccountingBillCreditNotesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |