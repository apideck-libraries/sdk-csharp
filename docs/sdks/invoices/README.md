# Invoices
(*Accounting.Invoices*)

## Overview

### Available Operations

* [List](#list) - List Invoices
* [Create](#create) - Create Invoice
* [Get](#get) - Get Invoice
* [Update](#update) - Update Invoice
* [Delete](#delete) - Delete Invoice

## List

List Invoices

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoicesAll" method="get" path="/accounting/invoices" -->
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

AccountingInvoicesAllRequest req = new AccountingInvoicesAllRequest() {
    ServiceId = "salesforce",
    Filter = new InvoicesFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        CreatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        Number = "OIT00546",
    },
    Sort = new InvoicesSort() {
        By = InvoicesSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingInvoicesAllResponse? res = await sdk.Accounting.Invoices.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingInvoicesAllRequest](../../Models/Requests/AccountingInvoicesAllRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingInvoicesAllResponse](../../Models/Requests/AccountingInvoicesAllResponse.md)**

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

Create Invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoicesAdd" method="post" path="/accounting/invoices" -->
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

AccountingInvoicesAddRequest req = new AccountingInvoicesAddRequest() {
    ServiceId = "salesforce",
    Invoice = new InvoiceInput() {
        Type = InvoiceType.Service,
        Number = "OIT00546",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        CompanyId = "12345",
        InvoiceDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        Terms = "Net 30 days",
        PoNumber = "90000117",
        Reference = "123456",
        Status = InvoiceStatus.Draft,
        InvoiceSent = true,
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 27500D,
        TotalTax = 2500D,
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Total = 27500D,
        Balance = 27500D,
        Deposit = 0D,
        CustomerMemo = "Thank you for your business and have a great day!",
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        LineItems = new List<InvoiceLineItemInput>() {
            new InvoiceLineItemInput() {
                Id = "12345",
                RowId = "12345",
                Code = "120-C",
                LineNumber = 1,
                Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
                Type = InvoiceLineItemType.SalesItem,
                TaxAmount = 27500D,
                TotalAmount = 27500D,
                Quantity = 1D,
                UnitPrice = 27500.5D,
                UnitOfMeasure = "pc.",
                DiscountPercentage = 0.01D,
                DiscountAmount = 19.99D,
                LocationId = "12345",
                DepartmentId = "12345",
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
                },
                TrackingCategories = new List<LinkedTrackingCategory?>() {
                    new LinkedTrackingCategory() {
                        Id = "123456",
                        Name = "New York",
                    },
                },
                LedgerAccount = null,
                CustomFields = new List<CustomField>() {
                    new CustomField() {
                        Id = "2389328923893298",
                        Name = "employee_level",
                        Description = "Employee Level",
                        Value = Value.CreateStr(
                            "Uses Salesforce and Marketo"
                        ),
                    },
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
            },
        },
        BillingAddress = new Address() {
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
        ShippingAddress = new Address() {
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
        TemplateId = "123456",
        SourceDocumentUrl = "https://www.invoicesolution.com/invoice/123456",
        PaymentAllocations = new List<PaymentAllocations>() {
            new PaymentAllocations() {
                Id = "123456",
                AllocatedAmount = 1000D,
                Date = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
            },
        },
        PaymentMethod = "cash",
        Channel = "email",
        Language = "EN",
        AccountingByRow = false,
        BankAccount = new BankAccount() {
            BankName = "Monzo",
            AccountNumber = "123465",
            AccountName = "SPACEX LLC",
            AccountType = AccountType.CreditCard,
            Iban = "CH2989144532982975332",
            Bic = "AUDSCHGGXXX",
            RoutingNumber = "012345678",
            BsbNumber = "062-001",
            BranchIdentifier = "001",
            BankCode = "BNH",
            Currency = Currency.Usd,
        },
        LedgerAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
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
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateStr(
                    "Uses Salesforce and Marketo"
                ),
            },
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

var res = await sdk.Accounting.Invoices.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingInvoicesAddRequest](../../Models/Requests/AccountingInvoicesAddRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingInvoicesAddResponse](../../Models/Requests/AccountingInvoicesAddResponse.md)**

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

Get Invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoicesOne" method="get" path="/accounting/invoices/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingInvoicesOneRequest req = new AccountingInvoicesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Invoices.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingInvoicesOneRequest](../../Models/Requests/AccountingInvoicesOneRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingInvoicesOneResponse](../../Models/Requests/AccountingInvoicesOneResponse.md)**

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

Update Invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoicesUpdate" method="patch" path="/accounting/invoices/{id}" -->
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

AccountingInvoicesUpdateRequest req = new AccountingInvoicesUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Invoice = new InvoiceInput() {
        Type = InvoiceType.Service,
        Number = "OIT00546",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        CompanyId = "12345",
        InvoiceDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        Terms = "Net 30 days",
        PoNumber = "90000117",
        Reference = "123456",
        Status = InvoiceStatus.Draft,
        InvoiceSent = true,
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 27500D,
        TotalTax = 2500D,
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Total = 27500D,
        Balance = 27500D,
        Deposit = 0D,
        CustomerMemo = "Thank you for your business and have a great day!",
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        LineItems = new List<InvoiceLineItemInput>() {
            new InvoiceLineItemInput() {
                Id = "12345",
                RowId = "12345",
                Code = "120-C",
                LineNumber = 1,
                Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
                Type = InvoiceLineItemType.SalesItem,
                TaxAmount = 27500D,
                TotalAmount = 27500D,
                Quantity = 1D,
                UnitPrice = 27500.5D,
                UnitOfMeasure = "pc.",
                DiscountPercentage = 0.01D,
                DiscountAmount = 19.99D,
                LocationId = "12345",
                DepartmentId = "12345",
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
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
                CustomFields = new List<CustomField>() {
                    new CustomField() {
                        Id = "2389328923893298",
                        Name = "employee_level",
                        Description = "Employee Level",
                        Value = null,
                    },
                    new CustomField() {
                        Id = "2389328923893298",
                        Name = "employee_level",
                        Description = "Employee Level",
                        Value = null,
                    },
                    new CustomField() {
                        Id = "2389328923893298",
                        Name = "employee_level",
                        Description = "Employee Level",
                        Value = null,
                    },
                },
                RowVersion = "1-12345",
            },
        },
        BillingAddress = new Address() {
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
        ShippingAddress = new Address() {
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
        TemplateId = "123456",
        SourceDocumentUrl = "https://www.invoicesolution.com/invoice/123456",
        PaymentAllocations = new List<PaymentAllocations>() {
            new PaymentAllocations() {
                Id = "123456",
                AllocatedAmount = 1000D,
                Date = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
            },
            new PaymentAllocations() {
                Id = "123456",
                AllocatedAmount = 1000D,
                Date = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
            },
        },
        PaymentMethod = "cash",
        Channel = "email",
        Language = "EN",
        AccountingByRow = false,
        BankAccount = new BankAccount() {
            BankName = "Monzo",
            AccountNumber = "123465",
            AccountName = "SPACEX LLC",
            AccountType = AccountType.CreditCard,
            Iban = "CH2989144532982975332",
            Bic = "AUDSCHGGXXX",
            RoutingNumber = "012345678",
            BsbNumber = "062-001",
            BranchIdentifier = "001",
            BankCode = "BNH",
            Currency = Currency.Usd,
        },
        LedgerAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = null,
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

var res = await sdk.Accounting.Invoices.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingInvoicesUpdateRequest](../../Models/Requests/AccountingInvoicesUpdateRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingInvoicesUpdateResponse](../../Models/Requests/AccountingInvoicesUpdateResponse.md)**

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

Delete Invoice

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.invoicesDelete" method="delete" path="/accounting/invoices/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingInvoicesDeleteRequest req = new AccountingInvoicesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Invoices.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingInvoicesDeleteRequest](../../Models/Requests/AccountingInvoicesDeleteRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingInvoicesDeleteResponse](../../Models/Requests/AccountingInvoicesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |