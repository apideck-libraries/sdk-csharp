# Accounting.SalesReceipts

## Overview

### Available Operations

* [List](#list) - List Sales Receipts
* [Create](#create) - Create Sales Receipt
* [Get](#get) - Get Sales Receipt
* [Update](#update) - Update Sales Receipt
* [Delete](#delete) - Delete Sales Receipt

## List

List Sales Receipts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesReceiptsAll" method="get" path="/accounting/sales-receipts" -->
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

AccountingSalesReceiptsAllRequest req = new AccountingSalesReceiptsAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Filter = new SalesReceiptsFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        CustomerId = "123abc",
    },
    Sort = new SalesReceiptsSort() {
        By = SalesReceiptsSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingSalesReceiptsAllResponse? res = await sdk.Accounting.SalesReceipts.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingSalesReceiptsAllRequest](../../Models/Requests/AccountingSalesReceiptsAllRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingSalesReceiptsAllResponse](../../Models/Requests/AccountingSalesReceiptsAllResponse.md)**

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

Create Sales Receipt

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesReceiptsAdd" method="post" path="/accounting/sales-receipts" -->
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

AccountingSalesReceiptsAddRequest req = new AccountingSalesReceiptsAddRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    SalesReceipt = new SalesReceiptInput() {
        Number = "SR-00001",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 250D,
        TotalAmount = 49.99D,
        TotalTax = 25D,
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        PaymentMethod = "cash",
        PaymentMethodReference = "123456",
        PaymentMethodId = "12345",
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
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
                ServiceDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-01-15")),
                CategoryId = "12345",
                LocationId = "12345",
                DepartmentId = "12345",
                SubsidiaryId = "12345",
                ShippingId = "12345",
                Memo = "Some memo",
                Prepaid = true,
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxApplicableOn = "Domestic_Purchase_of_Goods_and_Services",
                TaxRecoverability = "Fully_Recoverable",
                TaxMethod = "Due_to_Supplier",
                Worktags = new List<LinkedWorktag?>() {
                    new LinkedWorktag() {
                        Id = "123456",
                        Value = "New York",
                    },
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Code = "N-T",
                    Rate = 10D,
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
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    Name = "Bank account",
                    NominalCode = "N091",
                    Code = "453",
                    ParentId = "123456",
                    DisplayId = "123456",
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
            },
        },
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Note = "Thank you for your purchase",
        CustomerMemo = "Thank you for your business and have a great day!",
        Reference = "REF-123456",
        BillingAddress = new Address() {
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
        ShippingAddress = new Address() {
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
        Department = new LinkedDepartmentInput() {
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
        },
    },
};

var res = await sdk.Accounting.SalesReceipts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingSalesReceiptsAddRequest](../../Models/Requests/AccountingSalesReceiptsAddRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingSalesReceiptsAddResponse](../../Models/Requests/AccountingSalesReceiptsAddResponse.md)**

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

Get Sales Receipt

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesReceiptsOne" method="get" path="/accounting/sales-receipts/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingSalesReceiptsOneRequest req = new AccountingSalesReceiptsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.SalesReceipts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingSalesReceiptsOneRequest](../../Models/Requests/AccountingSalesReceiptsOneRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingSalesReceiptsOneResponse](../../Models/Requests/AccountingSalesReceiptsOneResponse.md)**

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

Update Sales Receipt

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesReceiptsUpdate" method="patch" path="/accounting/sales-receipts/{id}" -->
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

AccountingSalesReceiptsUpdateRequest req = new AccountingSalesReceiptsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
    SalesReceipt = new SalesReceiptInput() {
        Number = "SR-00001",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 250D,
        TotalAmount = 49.99D,
        TotalTax = 25D,
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        PaymentMethod = "cash",
        PaymentMethodReference = "123456",
        PaymentMethodId = "12345",
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            Name = "Bank account",
            NominalCode = "N091",
            Code = "453",
            ParentId = "123456",
            DisplayId = "123456",
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
                ServiceDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-01-15")),
                CategoryId = "12345",
                LocationId = "12345",
                DepartmentId = "12345",
                SubsidiaryId = "12345",
                ShippingId = "12345",
                Memo = "Some memo",
                Prepaid = true,
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxApplicableOn = "Domestic_Purchase_of_Goods_and_Services",
                TaxRecoverability = "Fully_Recoverable",
                TaxMethod = "Due_to_Supplier",
                Worktags = new List<LinkedWorktag?>() {
                    new LinkedWorktag() {
                        Id = "123456",
                        Value = "New York",
                    },
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Code = "N-T",
                    Rate = 10D,
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
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    Name = "Bank account",
                    NominalCode = "N091",
                    Code = "453",
                    ParentId = "123456",
                    DisplayId = "123456",
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
            },
        },
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Note = "Thank you for your purchase",
        CustomerMemo = "Thank you for your business and have a great day!",
        Reference = "REF-123456",
        BillingAddress = new Address() {
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
        ShippingAddress = new Address() {
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
        Department = new LinkedDepartmentInput() {
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
        },
    },
};

var res = await sdk.Accounting.SalesReceipts.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [AccountingSalesReceiptsUpdateRequest](../../Models/Requests/AccountingSalesReceiptsUpdateRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[AccountingSalesReceiptsUpdateResponse](../../Models/Requests/AccountingSalesReceiptsUpdateResponse.md)**

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

Delete Sales Receipt

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesReceiptsDelete" method="delete" path="/accounting/sales-receipts/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingSalesReceiptsDeleteRequest req = new AccountingSalesReceiptsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
};

var res = await sdk.Accounting.SalesReceipts.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [AccountingSalesReceiptsDeleteRequest](../../Models/Requests/AccountingSalesReceiptsDeleteRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[AccountingSalesReceiptsDeleteResponse](../../Models/Requests/AccountingSalesReceiptsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |