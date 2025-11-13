# Leads
(*Crm.Leads*)

## Overview

### Available Operations

* [List](#list) - List leads
* [Create](#create) - Create lead
* [Get](#get) - Get lead
* [Update](#update) - Update lead
* [Delete](#delete) - Delete lead

## List

List leads

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.leadsAll" method="get" path="/crm/leads" -->
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

CrmLeadsAllRequest req = new CrmLeadsAllRequest() {
    ServiceId = "salesforce",
    Filter = new LeadsFilter() {
        FirstName = "Elon",
        LastName = "Musk",
        Email = "elon@tesla.com",
        PhoneNumber = "1234567890",
    },
    Sort = new LeadsSort() {
        By = LeadsSortBy.CreatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

CrmLeadsAllResponse? res = await sdk.Crm.Leads.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CrmLeadsAllRequest](../../Models/Requests/CrmLeadsAllRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CrmLeadsAllResponse](../../Models/Requests/CrmLeadsAllResponse.md)**

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

Create lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.leadsAdd" method="post" path="/crm/leads" -->
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

CrmLeadsAddRequest req = new CrmLeadsAddRequest() {
    ServiceId = "salesforce",
    Lead = new LeadInput() {
        Name = "Elon Musk",
        CompanyName = "Spacex",
        OwnerId = "54321",
        OwnerName = "John Doe",
        CompanyId = "2",
        LeadId = "2",
        LeadSource = "Cold Call",
        FirstName = "Elon",
        LastName = "Musk",
        Description = "A thinker",
        Prefix = "Sir",
        Title = "CEO",
        Language = "EN",
        Status = "New",
        MonetaryAmount = 75000D,
        Currency = Currency.Usd,
        Fax = "+12129876543",
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
        },
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
        SocialLinks = new List<SocialLink>() {
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
            },
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
            },
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
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
            new Email() {
                Id = "123",
                EmailValue = "elon@musk.com",
                Type = EmailType.Primary,
            },
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
        },
        Tags = new List<string>() {
            "New",
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

var res = await sdk.Crm.Leads.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CrmLeadsAddRequest](../../Models/Requests/CrmLeadsAddRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CrmLeadsAddResponse](../../Models/Requests/CrmLeadsAddResponse.md)**

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

Get lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.leadsOne" method="get" path="/crm/leads/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

CrmLeadsOneRequest req = new CrmLeadsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Crm.Leads.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CrmLeadsOneRequest](../../Models/Requests/CrmLeadsOneRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CrmLeadsOneResponse](../../Models/Requests/CrmLeadsOneResponse.md)**

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

Update lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.leadsUpdate" method="patch" path="/crm/leads/{id}" -->
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

CrmLeadsUpdateRequest req = new CrmLeadsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Lead = new LeadInput() {
        Name = "Elon Musk",
        CompanyName = "Spacex",
        OwnerId = "54321",
        OwnerName = "John Doe",
        CompanyId = "2",
        LeadId = "2",
        LeadSource = "Cold Call",
        FirstName = "Elon",
        LastName = "Musk",
        Description = "A thinker",
        Prefix = "Sir",
        Title = "CEO",
        Language = "EN",
        Status = "New",
        MonetaryAmount = 75000D,
        Currency = Currency.Usd,
        Fax = "+12129876543",
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
        SocialLinks = new List<SocialLink>() {
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
            },
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
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
        Tags = new List<string>() {
            "New",
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

var res = await sdk.Crm.Leads.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CrmLeadsUpdateRequest](../../Models/Requests/CrmLeadsUpdateRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CrmLeadsUpdateResponse](../../Models/Requests/CrmLeadsUpdateResponse.md)**

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

Delete lead

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.leadsDelete" method="delete" path="/crm/leads/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

CrmLeadsDeleteRequest req = new CrmLeadsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Crm.Leads.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CrmLeadsDeleteRequest](../../Models/Requests/CrmLeadsDeleteRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CrmLeadsDeleteResponse](../../Models/Requests/CrmLeadsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |