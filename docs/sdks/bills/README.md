# Bills
(*Accounting.Bills*)

## Overview

### Available Operations

* [List](#list) - List Bills
* [Create](#create) - Create Bill
* [Get](#get) - Get Bill
* [Update](#update) - Update Bill
* [Delete](#delete) - Delete Bill

## List

List Bills

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingBillsAllRequest req = new AccountingBillsAllRequest() {
    ServiceId = "salesforce",
    Filter = new BillsFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
    },
    Sort = new BillsSort() {
        By = By.UpdatedAt,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingBillsAllResponse? res = await sdk.Accounting.Bills.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AccountingBillsAllRequest](../../Models/Requests/AccountingBillsAllRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[AccountingBillsAllResponse](../../Models/Requests/AccountingBillsAllResponse.md)**

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

Create Bill

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingBillsAddRequest req = new AccountingBillsAddRequest() {
    Bill = new BillInput() {
        BillNumber = "10001",
        Supplier = new LinkedSupplierInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Address = new Address() {
                Id = "123",
                Type = AddressType.Primary,
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
        CompanyId = "12345",
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        BillDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        PaidDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        PoNumber = "90000117",
        Reference = "123456",
        LineItems = new List<BillLineItemInput>() {
            new BillLineItemInput() {
                RowId = "12345",
                Code = "120-C",
                LineNumber = 1,
                Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
                Type = BillLineItemType.ExpenseAccount,
                TaxAmount = 27500D,
                TotalAmount = 27500D,
                Quantity = 1D,
                UnitPrice = 27500.5D,
                UnitOfMeasure = "pc.",
                DiscountPercentage = 0.01D,
                DiscountAmount = 19.99D,
                LocationId = "1234",
                DepartmentId = "1234",
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
                },
                LedgerAccount = new LinkedLedgerAccountInput() {
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
                RowVersion = "1-12345",
            },
        },
        Terms = "Net 30 days",
        Balance = 27500D,
        Deposit = 0D,
        SubTotal = 27500D,
        TotalTax = 2500D,
        Total = 27500D,
        TaxCode = "1234",
        Notes = "Some notes about this bill.",
        Status = BillStatus.Draft,
        LedgerAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
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
        DiscountPercentage = 5.5D,
        TrackingCategories = new List<LinkedTrackingCategory>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        RowVersion = "1-12345",
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateBoolean(
                    true
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
                },
            },
        },
        AccountingPeriod = "01-24",
    },
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Bills.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AccountingBillsAddRequest](../../Models/Requests/AccountingBillsAddRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[AccountingBillsAddResponse](../../Models/Requests/AccountingBillsAddResponse.md)**

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

Get Bill

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingBillsOneRequest req = new AccountingBillsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Bills.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AccountingBillsOneRequest](../../Models/Requests/AccountingBillsOneRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[AccountingBillsOneResponse](../../Models/Requests/AccountingBillsOneResponse.md)**

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

Update Bill

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingBillsUpdateRequest req = new AccountingBillsUpdateRequest() {
    Id = "<id>",
    Bill = new BillInput() {
        BillNumber = "10001",
        Supplier = new LinkedSupplierInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Address = new Address() {
                Id = "123",
                Type = AddressType.Primary,
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
        CompanyId = "12345",
        Currency = Currency.Usd,
        CurrencyRate = 0.69D,
        TaxInclusive = true,
        BillDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-09-30")),
        DueDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        PaidDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        PoNumber = "90000117",
        Reference = "123456",
        LineItems = new List<BillLineItemInput>() {
            new BillLineItemInput() {
                RowId = "12345",
                Code = "120-C",
                LineNumber = 1,
                Description = "Model Y is a fully electric, mid-size SUV, with seating for up to seven, dual motor AWD and unparalleled protection.",
                Type = BillLineItemType.ExpenseAccount,
                TaxAmount = 27500D,
                TotalAmount = 27500D,
                Quantity = 1D,
                UnitPrice = 27500.5D,
                UnitOfMeasure = "pc.",
                DiscountPercentage = 0.01D,
                DiscountAmount = 19.99D,
                LocationId = "1234",
                DepartmentId = "1234",
                Item = new LinkedInvoiceItem() {
                    Id = "12344",
                    Code = "120-C",
                    Name = "Model Y",
                },
                TaxRate = new LinkedTaxRateInput() {
                    Id = "123456",
                    Rate = 10D,
                },
                LedgerAccount = new LinkedLedgerAccountInput() {
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
                RowVersion = "1-12345",
            },
        },
        Terms = "Net 30 days",
        Balance = 27500D,
        Deposit = 0D,
        SubTotal = 27500D,
        TotalTax = 2500D,
        Total = 27500D,
        TaxCode = "1234",
        Notes = "Some notes about this bill.",
        Status = BillStatus.Draft,
        LedgerAccount = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
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
        DiscountPercentage = 5.5D,
        TrackingCategories = new List<LinkedTrackingCategory>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        RowVersion = "1-12345",
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateArrayOf6(
                    new List<Six>() {
                        new Six() {},
                    }
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
                },
            },
        },
        AccountingPeriod = "01-24",
    },
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Bills.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingBillsUpdateRequest](../../Models/Requests/AccountingBillsUpdateRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingBillsUpdateResponse](../../Models/Requests/AccountingBillsUpdateResponse.md)**

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

Delete Bill

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingBillsDeleteRequest req = new AccountingBillsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Bills.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingBillsDeleteRequest](../../Models/Requests/AccountingBillsDeleteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingBillsDeleteResponse](../../Models/Requests/AccountingBillsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |