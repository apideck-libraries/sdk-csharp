# ApideckCompanies
(*Hris.Companies*)

## Overview

### Available Operations

* [List](#list) - List Companies
* [Create](#create) - Create Company
* [Get](#get) - Get Company
* [Update](#update) - Update Company
* [Delete](#delete) - Delete Company

## List

List Companies

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using System.Collections.Generic;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisCompaniesAllRequest req = new HrisCompaniesAllRequest() {
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Hris.Companies.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisCompaniesAllRequest](../../Models/Requests/HrisCompaniesAllRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisCompaniesAllResponse](../../Models/Requests/HrisCompaniesAllResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Create

Create Company

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisCompaniesAddRequest req = new HrisCompaniesAddRequest() {
    HrisCompany = new HrisCompanyInput() {
        LegalName = "SpaceX",
        DisplayName = "SpaceX",
        Subdomain = "company",
        Status = Unify.Models.Components.HrisCompanyStatus.Active,
        CompanyNumber = "123456-AB",
        Currency = Unify.Models.Components.Currency.Usd,
        Addresses = new List<Address>() {
            new Address() {
                Id = "123",
                Type = Unify.Models.Components.Type.Primary,
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
                Type = Unify.Models.Components.PhoneNumberType.Primary,
            },
        },
        Emails = new List<Email>() {
            new Email() {
                Id = "123",
                Email = "elon@musk.com",
                Type = Unify.Models.Components.EmailType.Primary,
            },
        },
        Websites = new List<Website>() {
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = Unify.Models.Components.WebsiteType.Primary,
            },
        },
        DebtorId = "12345",
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
    ServiceId = "salesforce",
};

var res = await sdk.Hris.Companies.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisCompaniesAddRequest](../../Models/Requests/HrisCompaniesAddRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisCompaniesAddResponse](../../Models/Requests/HrisCompaniesAddResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Get

Get Company

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisCompaniesOneRequest req = new HrisCompaniesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Hris.Companies.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisCompaniesOneRequest](../../Models/Requests/HrisCompaniesOneRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisCompaniesOneResponse](../../Models/Requests/HrisCompaniesOneResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Update

Update Company

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisCompaniesUpdateRequest req = new HrisCompaniesUpdateRequest() {
    Id = "<id>",
    HrisCompany = new HrisCompanyInput() {
        LegalName = "SpaceX",
        DisplayName = "SpaceX",
        Subdomain = "company",
        Status = Unify.Models.Components.HrisCompanyStatus.Active,
        CompanyNumber = "123456-AB",
        Currency = Unify.Models.Components.Currency.Usd,
        Addresses = new List<Address>() {
            new Address() {
                Id = "123",
                Type = Unify.Models.Components.Type.Primary,
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
                Type = Unify.Models.Components.PhoneNumberType.Primary,
            },
        },
        Emails = new List<Email>() {
            new Email() {
                Id = "123",
                Email = "elon@musk.com",
                Type = Unify.Models.Components.EmailType.Primary,
            },
        },
        Websites = new List<Website>() {
            new Website() {
                Id = "12345",
                Url = "http://example.com",
                Type = Unify.Models.Components.WebsiteType.Primary,
            },
        },
        DebtorId = "12345",
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
    ServiceId = "salesforce",
};

var res = await sdk.Hris.Companies.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisCompaniesUpdateRequest](../../Models/Requests/HrisCompaniesUpdateRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisCompaniesUpdateResponse](../../Models/Requests/HrisCompaniesUpdateResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |

## Delete

Delete Company

### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisCompaniesDeleteRequest req = new HrisCompaniesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Hris.Companies.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisCompaniesDeleteRequest](../../Models/Requests/HrisCompaniesDeleteRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisCompaniesDeleteResponse](../../Models/Requests/HrisCompaniesDeleteResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |