# Accounting.Customers

## Overview

### Available Operations

* [List](#list) - List Customers
* [Create](#create) - Create Customer
* [Get](#get) - Get Customer
* [Update](#update) - Update Customer
* [Delete](#delete) - Delete Customer

## List

List Customers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.customersAll" method="get" path="/accounting/customers" -->
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

AccountingCustomersAllRequest req = new AccountingCustomersAllRequest() {
    ServiceId = "salesforce",
    Filter = new CustomersFilter() {
        CompanyName = "SpaceX",
        DisplayName = "Elon Musk",
        FirstName = "Elon",
        LastName = "Musk",
        Email = "elon@musk.com",
        Status = CustomersFilterStatus.Active,
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        SupplierId = "123",
    },
    Sort = new CustomersSort() {
        By = CustomersSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingCustomersAllResponse? res = await sdk.Accounting.Customers.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingCustomersAllRequest](../../Models/Requests/AccountingCustomersAllRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingCustomersAllResponse](../../Models/Requests/AccountingCustomersAllResponse.md)**

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

Create Customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.customersAdd" method="post" path="/accounting/customers" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingCustomersAddRequest req = new AccountingCustomersAddRequest() {
    ServiceId = "salesforce",
    Customer = new CustomerInput() {
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
        Project = false,
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
                EmailValue = "elon@musk.com",
                Type = EmailType.Primary,
            },
        },
        Websites = new List<Website>() {
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = WebsiteType.Primary,
            },
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = WebsiteType.Primary,
            },
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
        Notes = "Some notes about this customer",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TaxNumber = "US123945459",
        Currency = Currency.Usd,
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        Parent = new LinkedParentCustomer() {
            Id = "12345",
            Name = "Windsurf Shop",
        },
        Status = CustomerStatusStatus.Active,
        PaymentMethod = "cash",
        Channel = "email",
        CustomFields = new List<CustomField>() {
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = null,
                }
            ),
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = null,
                }
            ),
            CustomField.CreateCustomField1(
                new CustomField1() {
                    Id = "2389328923893298",
                    Name = "employee_level",
                    Description = "Employee Level",
                    Value = null,
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
        },
    },
};

var res = await sdk.Accounting.Customers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingCustomersAddRequest](../../Models/Requests/AccountingCustomersAddRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingCustomersAddResponse](../../Models/Requests/AccountingCustomersAddResponse.md)**

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

Get Customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.customersOne" method="get" path="/accounting/customers/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingCustomersOneRequest req = new AccountingCustomersOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Customers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingCustomersOneRequest](../../Models/Requests/AccountingCustomersOneRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingCustomersOneResponse](../../Models/Requests/AccountingCustomersOneResponse.md)**

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

Update Customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.customersUpdate" method="patch" path="/accounting/customers/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingCustomersUpdateRequest req = new AccountingCustomersUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Customer = new CustomerInput() {
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
        Project = false,
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
                EmailValue = "elon@musk.com",
                Type = EmailType.Primary,
            },
        },
        Websites = new List<Website>() {
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = WebsiteType.Primary,
            },
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = WebsiteType.Primary,
            },
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
        Notes = "Some notes about this customer",
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TaxNumber = "US123945459",
        Currency = Currency.Usd,
        Account = new LinkedLedgerAccount() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        Parent = new LinkedParentCustomer() {
            Id = "12345",
            Name = "Windsurf Shop",
        },
        Status = CustomerStatusStatus.Active,
        PaymentMethod = "cash",
        Channel = "email",
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

var res = await sdk.Accounting.Customers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingCustomersUpdateRequest](../../Models/Requests/AccountingCustomersUpdateRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingCustomersUpdateResponse](../../Models/Requests/AccountingCustomersUpdateResponse.md)**

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

Delete Customer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.customersDelete" method="delete" path="/accounting/customers/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingCustomersDeleteRequest req = new AccountingCustomersDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Customers.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AccountingCustomersDeleteRequest](../../Models/Requests/AccountingCustomersDeleteRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AccountingCustomersDeleteResponse](../../Models/Requests/AccountingCustomersDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |