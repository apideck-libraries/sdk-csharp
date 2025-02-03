# Suppliers
(*Accounting.Suppliers*)

## Overview

### Available Operations

* [List](#list) - List Suppliers
* [Create](#create) - Create Supplier
* [Get](#get) - Get Supplier
* [Update](#update) - Update Supplier
* [Delete](#delete) - Delete Supplier

## List

List Suppliers

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

AccountingSuppliersAllRequest req = new AccountingSuppliersAllRequest() {
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
    Filter = new SuppliersFilter() {
        CompanyName = "SpaceX",
        DisplayName = "Elon Musk",
        FirstName = "Elon",
        LastName = "Musk",
        Email = "elon@musk.com",
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
    },
    Sort = new SuppliersSort() {
        By = SuppliersSortBy.UpdatedAt,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingSuppliersAllResponse? res = await sdk.Accounting.Suppliers.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingSuppliersAllRequest](../../Models/Requests/AccountingSuppliersAllRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingSuppliersAllResponse](../../Models/Requests/AccountingSuppliersAllResponse.md)**

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

Create Supplier

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingSuppliersAddRequest req = new AccountingSuppliersAddRequest() {
    Supplier = new SupplierInput() {
        DisplayId = "EMP00101",
        DisplayName = "Windsurf Shop",
        CompanyName = "SpaceX",
        CompanyId = "12345",
        Title = "CEO",
        FirstName = "Elon",
        MiddleName = "D.",
        LastName = "Musk",
        Suffix = "Jr.",
        Individual = true,
        Addresses = new List<Address>() {
            new Address() {
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
        PhoneNumbers = new List<PhoneNumber>() {
            new PhoneNumber() {
                Id = "12345",
                CountryCode = "1",
                AreaCode = "323",
                Number = "111-111-1111",
                Extension = "105",
                Type = PhoneNumberType.Primary,
            },
        },
        Emails = new List<Email>() {
            new Email() {
                Id = "123",
                Email = "elon@musk.com",
                Type = EmailType.Primary,
            },
        },
        Websites = new List<Website>() {
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = WebsiteType.Primary,
            },
        },
        BankAccounts = new List<BankAccount>() {
            new BankAccount() {
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
        },
        Notes = "Some notes about this supplier",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TaxNumber = "US123945459",
        Currency = Currency.Usd,
        Account = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        Status = SupplierStatus.Active,
        PaymentMethod = "cash",
        Channel = "email",
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
        SubsidiaryId = "12345",
    },
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Suppliers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingSuppliersAddRequest](../../Models/Requests/AccountingSuppliersAddRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingSuppliersAddResponse](../../Models/Requests/AccountingSuppliersAddResponse.md)**

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

Get Supplier

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

AccountingSuppliersOneRequest req = new AccountingSuppliersOneRequest() {
    Id = "<id>",
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Suppliers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingSuppliersOneRequest](../../Models/Requests/AccountingSuppliersOneRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingSuppliersOneResponse](../../Models/Requests/AccountingSuppliersOneResponse.md)**

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

Update Supplier

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingSuppliersUpdateRequest req = new AccountingSuppliersUpdateRequest() {
    Id = "<id>",
    Supplier = new SupplierInput() {
        DisplayId = "EMP00101",
        DisplayName = "Windsurf Shop",
        CompanyName = "SpaceX",
        CompanyId = "12345",
        Title = "CEO",
        FirstName = "Elon",
        MiddleName = "D.",
        LastName = "Musk",
        Suffix = "Jr.",
        Individual = true,
        Addresses = new List<Address>() {
            new Address() {
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
        PhoneNumbers = new List<PhoneNumber>() {
            new PhoneNumber() {
                Id = "12345",
                CountryCode = "1",
                AreaCode = "323",
                Number = "111-111-1111",
                Extension = "105",
                Type = PhoneNumberType.Primary,
            },
        },
        Emails = new List<Email>() {
            new Email() {
                Id = "123",
                Email = "elon@musk.com",
                Type = EmailType.Primary,
            },
        },
        Websites = new List<Website>() {
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = WebsiteType.Primary,
            },
        },
        BankAccounts = new List<BankAccount>() {
            new BankAccount() {
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
        },
        Notes = "Some notes about this supplier",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TaxNumber = "US123945459",
        Currency = Currency.Usd,
        Account = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        Status = SupplierStatus.Active,
        PaymentMethod = "cash",
        Channel = "email",
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
        SubsidiaryId = "12345",
    },
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Suppliers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingSuppliersUpdateRequest](../../Models/Requests/AccountingSuppliersUpdateRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingSuppliersUpdateResponse](../../Models/Requests/AccountingSuppliersUpdateResponse.md)**

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

Delete Supplier

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

AccountingSuppliersDeleteRequest req = new AccountingSuppliersDeleteRequest() {
    Id = "<id>",
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Suppliers.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingSuppliersDeleteRequest](../../Models/Requests/AccountingSuppliersDeleteRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingSuppliersDeleteResponse](../../Models/Requests/AccountingSuppliersDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |