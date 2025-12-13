# Accounting.PurchaseOrders

## Overview

### Available Operations

* [List](#list) - List Purchase Orders
* [Create](#create) - Create Purchase Order
* [Get](#get) - Get Purchase Order
* [Update](#update) - Update Purchase Order
* [Delete](#delete) - Delete Purchase Order

## List

List Purchase Orders

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.purchaseOrdersAll" method="get" path="/accounting/purchase-orders" -->
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

AccountingPurchaseOrdersAllRequest req = new AccountingPurchaseOrdersAllRequest() {
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Filter = new PurchaseOrdersFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        SupplierId = "1234",
    },
    Sort = new PurchaseOrdersSort() {
        By = PurchaseOrdersSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
};

AccountingPurchaseOrdersAllResponse? res = await sdk.Accounting.PurchaseOrders.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingPurchaseOrdersAllRequest](../../Models/Requests/AccountingPurchaseOrdersAllRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingPurchaseOrdersAllResponse](../../Models/Requests/AccountingPurchaseOrdersAllResponse.md)**

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

Create Purchase Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.purchaseOrdersAdd" method="post" path="/accounting/purchase-orders" -->
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

AccountingPurchaseOrdersAddRequest req = new AccountingPurchaseOrdersAddRequest() {
    ServiceId = "salesforce",
    PurchaseOrder = new PurchaseOrderInput() {
        PoNumber = "90000117",
        Reference = "123456",
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
        SubsidiaryId = "12345",
        CompanyId = "12345",
        Status = PurchaseOrderStatus.Open,
        IssuedDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DeliveryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        ExpectedArrivalDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        SubTotal = 27500D,
        TotalTax = 2500D,
        Total = 27500D,
        TaxInclusive = true,
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
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
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
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
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
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
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
        LedgerAccount = new LinkedLedgerAccount() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        TemplateId = "123456",
        DiscountPercentage = 5.5D,
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
        AccountingByRow = false,
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        PaymentMethod = "cash",
        TaxCode = "1234",
        Channel = "email",
        Memo = "Thank you for the partnership and have a great day!",
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
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

var res = await sdk.Accounting.PurchaseOrders.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingPurchaseOrdersAddRequest](../../Models/Requests/AccountingPurchaseOrdersAddRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingPurchaseOrdersAddResponse](../../Models/Requests/AccountingPurchaseOrdersAddResponse.md)**

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

Get Purchase Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.purchaseOrdersOne" method="get" path="/accounting/purchase-orders/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingPurchaseOrdersOneRequest req = new AccountingPurchaseOrdersOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.PurchaseOrders.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingPurchaseOrdersOneRequest](../../Models/Requests/AccountingPurchaseOrdersOneRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingPurchaseOrdersOneResponse](../../Models/Requests/AccountingPurchaseOrdersOneResponse.md)**

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

Update Purchase Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.purchaseOrdersUpdate" method="patch" path="/accounting/purchase-orders/{id}" -->
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

AccountingPurchaseOrdersUpdateRequest req = new AccountingPurchaseOrdersUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    PurchaseOrder = new PurchaseOrderInput() {
        PoNumber = "90000117",
        Reference = "123456",
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
        SubsidiaryId = "12345",
        CompanyId = "12345",
        Status = PurchaseOrderStatus.Open,
        IssuedDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DeliveryDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        ExpectedArrivalDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        SubTotal = 27500D,
        TotalTax = 2500D,
        Total = 27500D,
        TaxInclusive = true,
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
                TrackingCategories = null,
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
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
            },
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
                TrackingCategories = null,
                LedgerAccount = new LinkedLedgerAccount() {
                    Id = "123456",
                    NominalCode = "N091",
                    Code = "453",
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
            },
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
        LedgerAccount = new LinkedLedgerAccount() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        TemplateId = "123456",
        DiscountPercentage = 5.5D,
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
        AccountingByRow = false,
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        PaymentMethod = "cash",
        TaxCode = "1234",
        Channel = "email",
        Memo = "Thank you for the partnership and have a great day!",
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
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
        },
    },
};

var res = await sdk.Accounting.PurchaseOrders.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingPurchaseOrdersUpdateRequest](../../Models/Requests/AccountingPurchaseOrdersUpdateRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingPurchaseOrdersUpdateResponse](../../Models/Requests/AccountingPurchaseOrdersUpdateResponse.md)**

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

Delete Purchase Order

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.purchaseOrdersDelete" method="delete" path="/accounting/purchase-orders/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingPurchaseOrdersDeleteRequest req = new AccountingPurchaseOrdersDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.PurchaseOrders.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [AccountingPurchaseOrdersDeleteRequest](../../Models/Requests/AccountingPurchaseOrdersDeleteRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[AccountingPurchaseOrdersDeleteResponse](../../Models/Requests/AccountingPurchaseOrdersDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |