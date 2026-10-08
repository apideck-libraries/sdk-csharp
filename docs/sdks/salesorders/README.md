# Accounting.SalesOrders

## Overview

### Available Operations

* [List](#list) - List Sales Orders
* [Create](#create) - Create Sales Order
* [Get](#get) - Get Sales Order
* [Update](#update) - Update Sales Order
* [Delete](#delete) - Delete Sales Order

## List

List Sales Orders

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesOrdersAll" method="get" path="/accounting/sales-orders" -->
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

AccountingSalesOrdersAllRequest req = new AccountingSalesOrdersAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Filter = new SalesOrdersFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        CreatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
        Number = "SO000123",
        CustomerId = "123abc",
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
};

AccountingSalesOrdersAllResponse? res = await sdk.Accounting.SalesOrders.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingSalesOrdersAllRequest](../../Models/Requests/AccountingSalesOrdersAllRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingSalesOrdersAllResponse](../../Models/Requests/AccountingSalesOrdersAllResponse.md)**

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

Create Sales Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesOrdersAdd" method="post" path="/accounting/sales-orders" -->
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

AccountingSalesOrdersAddRequest req = new AccountingSalesOrdersAddRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    SalesOrder = new SalesOrderInput() {
        Number = "SO000123",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        QuoteId = "123456",
        CompanyId = "12345",
        DepartmentId = "12345",
        LocationId = "12345",
        ProjectId = "12345",
        SubsidiaryId = "12345",
        OrderDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DeliveryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-15")),
        OrderType = "SO",
        Terms = "Net 30",
        TermsId = "12345",
        PoNumber = "90000117",
        Reference = "INV-2024-001",
        Status = SalesOrderStatus.Open,
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 27500D,
        TotalTax = 2500D,
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Total = 30000D,
        ShippingMethod = "FEDEX",
        PaymentMethod = "cash",
        CustomerMemo = "Thank you for your order!",
        Notes = "Ship with next consignment",
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
                            RefName = "Marketing",
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
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Code = "100",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        TemplateId = "123456",
        SourceDocumentUrl = "https://www.ordersolution.com/order/123456",
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

var res = await sdk.Accounting.SalesOrders.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingSalesOrdersAddRequest](../../Models/Requests/AccountingSalesOrdersAddRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingSalesOrdersAddResponse](../../Models/Requests/AccountingSalesOrdersAddResponse.md)**

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

Get Sales Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesOrdersOne" method="get" path="/accounting/sales-orders/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingSalesOrdersOneRequest req = new AccountingSalesOrdersOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
};

var res = await sdk.Accounting.SalesOrders.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingSalesOrdersOneRequest](../../Models/Requests/AccountingSalesOrdersOneRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingSalesOrdersOneResponse](../../Models/Requests/AccountingSalesOrdersOneResponse.md)**

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

Update Sales Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesOrdersUpdate" method="patch" path="/accounting/sales-orders/{id}" -->
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

AccountingSalesOrdersUpdateRequest req = new AccountingSalesOrdersUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
    SalesOrder = new SalesOrderInput() {
        Number = "SO000123",
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        QuoteId = "123456",
        CompanyId = "12345",
        DepartmentId = "12345",
        LocationId = "12345",
        ProjectId = "12345",
        SubsidiaryId = "12345",
        OrderDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DeliveryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-15")),
        OrderType = "SO",
        Terms = "Net 30",
        TermsId = "12345",
        PoNumber = "90000117",
        Reference = "INV-2024-001",
        Status = SalesOrderStatus.Open,
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        SubTotal = 27500D,
        TotalTax = 2500D,
        TaxCode = "1234",
        DiscountPercentage = 5.5D,
        DiscountAmount = 25D,
        Total = 30000D,
        ShippingMethod = "FEDEX",
        PaymentMethod = "cash",
        CustomerMemo = "Thank you for your order!",
        Notes = "Ship with next consignment",
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
                            RefName = "Marketing",
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
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Code = "100",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        TemplateId = "123456",
        SourceDocumentUrl = "https://www.ordersolution.com/order/123456",
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

var res = await sdk.Accounting.SalesOrders.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingSalesOrdersUpdateRequest](../../Models/Requests/AccountingSalesOrdersUpdateRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingSalesOrdersUpdateResponse](../../Models/Requests/AccountingSalesOrdersUpdateResponse.md)**

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

Delete Sales Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.salesOrdersDelete" method="delete" path="/accounting/sales-orders/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingSalesOrdersDeleteRequest req = new AccountingSalesOrdersDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
};

var res = await sdk.Accounting.SalesOrders.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingSalesOrdersDeleteRequest](../../Models/Requests/AccountingSalesOrdersDeleteRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingSalesOrdersDeleteResponse](../../Models/Requests/AccountingSalesOrdersDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |