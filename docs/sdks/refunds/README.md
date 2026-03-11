# Accounting.Refunds

## Overview

### Available Operations

* [List](#list) - List Refunds
* [Create](#create) - Create Refund
* [Get](#get) - Get Refund
* [Update](#update) - Update Refund
* [Delete](#delete) - Delete Refund

## List

List Refunds

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.refundsAll" method="get" path="/accounting/refunds" -->
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

AccountingRefundsAllRequest req = new AccountingRefundsAllRequest() {
    ServiceId = "salesforce",
    Filter = new RefundsFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        CustomerId = "123abc",
    },
    Sort = new RefundsSort() {
        By = RefundsSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingRefundsAllResponse? res = await sdk.Accounting.Refunds.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [AccountingRefundsAllRequest](../../Models/Requests/AccountingRefundsAllRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[AccountingRefundsAllResponse](../../Models/Requests/AccountingRefundsAllResponse.md)**

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

Create Refund

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.refundsAdd" method="post" path="/accounting/refunds" -->
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

AccountingRefundsAddRequest req = new AccountingRefundsAddRequest() {
    ServiceId = "salesforce",
    Refund = new RefundInput() {
        Number = "RF-00001",
        Customer = null,
        CompanyId = "12345",
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 250D,
        TotalAmount = 49.99D,
        TotalTax = 25D,
        RefundDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        Status = RefundStatus.Paid,
        Type = RefundType.RefundReceipt,
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
        Allocations = new List<AllocationInput>() {
            new AllocationInput() {
                Id = "123456",
                Amount = 49.99D,
                AllocationId = "123456",
            },
        },
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Note = "Refund for returned items",
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
        Location = new LinkedLocationInput() {
            Id = "123456",
            DisplayId = "123456",
            Name = "New York Office",
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

var res = await sdk.Accounting.Refunds.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [AccountingRefundsAddRequest](../../Models/Requests/AccountingRefundsAddRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[AccountingRefundsAddResponse](../../Models/Requests/AccountingRefundsAddResponse.md)**

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

Get Refund

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.refundsOne" method="get" path="/accounting/refunds/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingRefundsOneRequest req = new AccountingRefundsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Refunds.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [AccountingRefundsOneRequest](../../Models/Requests/AccountingRefundsOneRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[AccountingRefundsOneResponse](../../Models/Requests/AccountingRefundsOneResponse.md)**

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

Update Refund

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.refundsUpdate" method="patch" path="/accounting/refunds/{id}" -->
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

AccountingRefundsUpdateRequest req = new AccountingRefundsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Refund = new RefundInput() {
        Number = "RF-00001",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        CompanyId = "12345",
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 250D,
        TotalAmount = 49.99D,
        TotalTax = 25D,
        RefundDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z").ToUniversalTime(),
        Status = RefundStatus.Paid,
        Type = RefundType.RefundReceipt,
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
        Allocations = new List<AllocationInput>() {
            new AllocationInput() {
                Id = "123456",
                Amount = 49.99D,
                AllocationId = "123456",
            },
        },
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Note = "Refund for returned items",
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
        Location = new LinkedLocationInput() {
            Id = "123456",
            DisplayId = "123456",
            Name = "New York Office",
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

var res = await sdk.Accounting.Refunds.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [AccountingRefundsUpdateRequest](../../Models/Requests/AccountingRefundsUpdateRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[AccountingRefundsUpdateResponse](../../Models/Requests/AccountingRefundsUpdateResponse.md)**

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

Delete Refund

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.refundsDelete" method="delete" path="/accounting/refunds/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingRefundsDeleteRequest req = new AccountingRefundsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Refunds.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [AccountingRefundsDeleteRequest](../../Models/Requests/AccountingRefundsDeleteRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[AccountingRefundsDeleteResponse](../../Models/Requests/AccountingRefundsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |