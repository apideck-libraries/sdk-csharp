# Accounting.Suppliers

## Overview

### Available Operations

* [List](#list) - List Suppliers
* [Create](#create) - Create Supplier
* [Get](#get) - Get Supplier
* [Update](#update) - Update Supplier
* [Delete](#delete) - Delete Supplier
* [CreateBatch](#createbatch) - Create Suppliers in batch

## List

List Suppliers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.suppliersAll" method="get" path="/accounting/suppliers" -->
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

AccountingSuppliersAllRequest req = new AccountingSuppliersAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Filter = new SuppliersFilter() {
        CompanyName = "SpaceX",
        DisplayName = "Elon Musk",
        FirstName = "Elon",
        LastName = "Musk",
        Email = "elon@musk.com",
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z").ToUniversalTime(),
    },
    Sort = new SuppliersSort() {
        By = SuppliersSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
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

<!-- UsageSnippet language="csharp" operationID="accounting.suppliersAdd" method="post" path="/accounting/suppliers" -->
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

AccountingSuppliersAddRequest req = new AccountingSuppliersAddRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
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
        },
        Notes = "Some notes about this supplier",
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
        Status = SupplierStatus.Active,
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

<!-- UsageSnippet language="csharp" operationID="accounting.suppliersOne" method="get" path="/accounting/suppliers/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingSuppliersOneRequest req = new AccountingSuppliersOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
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

<!-- UsageSnippet language="csharp" operationID="accounting.suppliersUpdate" method="patch" path="/accounting/suppliers/{id}" -->
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

AccountingSuppliersUpdateRequest req = new AccountingSuppliersUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
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
        Notes = "Some notes about this supplier",
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
        Status = SupplierStatus.Active,
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
        SubsidiaryId = "12345",
    },
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

<!-- UsageSnippet language="csharp" operationID="accounting.suppliersDelete" method="delete" path="/accounting/suppliers/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingSuppliersDeleteRequest req = new AccountingSuppliersDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
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

## CreateBatch

Create multiple suppliers in a single request. Each item is processed independently, so some may be created while others fail; the response returns `200` with one result per item, in the order the items were sent. The maximum number of items accepted per request depends on the connector.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.suppliersBatchAdd" method="post" path="/accounting/suppliers/batch" -->
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

AccountingSuppliersBatchAddRequest req = new AccountingSuppliersBatchAddRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    BatchSuppliersRequest = new BatchSuppliersRequest() {
        Items = new List<BatchSuppliersRequestItems>() {
            new BatchSuppliersRequestItems() {
                Ref = "item-1",
                Data = new SupplierCreateInput() {
                    DisplayId = "EMP00101",
                    DisplayName = "Windsurf Shop",
                    CompanyName = "SpaceX",
                    CompanyId = "12345",
                    Subsidiary = new LinkedSubsidiaryInput() {
                        DisplayId = "123456",
                        Name = "Acme Inc.",
                    },
                    SupplierCategory = "Insurance",
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
                    },
                    BankAccounts = new List<BankAccount>() {
                        new BankAccount() {
                            BankName = "Chase Bank",
                            AccountNumber = "123465",
                            AccountName = "Main Operating Account",
                            AccountType = AccountType.CreditCard,
                            Iban = "GB33BUKB20201555555555",
                            Bic = "CHASUS33",
                            RoutingNumber = "021000021",
                            BsbNumber = "062-001",
                            BranchIdentifier = "001",
                            BankCode = "BNH",
                            Currency = Currency.Usd,
                            Country = "US",
                        },
                    },
                    Notes = "Some notes about this supplier",
                    TaxRate = new LinkedTaxRateInput() {
                        Id = "123456",
                        Code = "N-T",
                        Rate = 10D,
                    },
                    TaxNumber = "US123945459",
                    Taxable = true,
                    Currency = Currency.Usd,
                    Account = new LinkedLedgerAccount() {
                        Id = "123456",
                        Name = "Bank account",
                        NominalCode = "N091",
                        Code = "453",
                        ParentId = "123456",
                        DisplayId = "123456",
                    },
                    Status = SupplierCreateInputStatus.Active,
                    PaymentMethod = "cash",
                    Terms = "Net 30 days",
                    TermsId = "12345",
                    Channel = "email",
                    IssuedMethod = "Email",
                    IssuedEmail = "john.doe@example.com",
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
                    TaxDetails = new List<LinkedTaxDetail?>() {
                        new LinkedTaxDetail() {
                            Type = "GST on Purchases",
                            Number = "123456",
                            IsTransactionTax = true,
                            IsPrimaryTax = true,
                        },
                    },
                    TaxStatusDetails = new List<LinkedTaxStatusDetail?>() {
                        new LinkedTaxStatusDetail() {
                            Country = "US",
                            TransactionTaxStatus = "taxable",
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
                    IntegrationSystemId = "12345",
                },
            },
        },
    },
};

var res = await sdk.Accounting.Suppliers.CreateBatchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AccountingSuppliersBatchAddRequest](../../Models/Requests/AccountingSuppliersBatchAddRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AccountingSuppliersBatchAddResponse](../../Models/Requests/AccountingSuppliersBatchAddResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |