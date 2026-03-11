# Ats.Jobs

## Overview

### Available Operations

* [List](#list) - List Jobs
* [Create](#create) - Create Job
* [Get](#get) - Get Job
* [Update](#update) - Update Job
* [Delete](#delete) - Delete Job

## List

List Jobs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats.jobsAll" method="get" path="/ats/jobs" -->
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

AtsJobsAllRequest req = new AtsJobsAllRequest() {
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AtsJobsAllResponse? res = await sdk.Ats.Jobs.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [AtsJobsAllRequest](../../Models/Requests/AtsJobsAllRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[AtsJobsAllResponse](../../Models/Requests/AtsJobsAllResponse.md)**

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

Create Job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats.jobsAdd" method="post" path="/ats/jobs" -->
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

AtsJobsAddRequest req = new AtsJobsAddRequest() {
    ServiceId = "salesforce",
    Job = new JobInput() {
        Slug = "ceo",
        Title = "CEO",
        Sequence = 3,
        Visibility = Visibility.Internal,
        Status = JobStatus.Completed,
        Code = "123-OC",
        Language = "EN",
        EmploymentTerms = EmploymentTerms.FullTime,
        Experience = "Director/ Vice President",
        Location = "San Francisco",
        Remote = true,
        RequisitionId = "abc123",
        Department = new DepartmentInput() {
            Name = "R&D",
            Code = "2",
            Description = "R&D",
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
        Branch = new JobBranch() {
            Name = "HQ NY",
        },
        Recruiters = new List<string>() {
            "a0d636c6-43b3-4bde-8c70-85b707d992f4",
        },
        HiringManagers = new List<string>() {
            "123456",
        },
        Followers = new List<string>() {
            "a0d636c6-43b3-4bde-8c70-85b707d992f4",
            "a98lfd96-43b3-4bde-8c70-85b707d992e6",
        },
        Description = "A description",
        Blocks = new List<Blocks>() {
            new Blocks() {
                Title = "string",
                Content = "string",
            },
        },
        Closing = "The closing section of the job description",
        ClosingDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        Salary = new Salary() {
            Min = 8000,
            Max = 10000,
            Currency = Currency.Usd,
            Interval = "year",
        },
        Links = new List<JobLinks>() {
            new JobLinks() {
                Type = JobType.JobPortal,
                Url = "https://app.intercom.io/contacts/12345",
            },
        },
        Confidential = false,
        AvailableToEmployees = false,
        Tags = new List<string>() {
            "New",
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
        Deleted = true,
        OwnerId = "54321",
    },
};

var res = await sdk.Ats.Jobs.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [AtsJobsAddRequest](../../Models/Requests/AtsJobsAddRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[AtsJobsAddResponse](../../Models/Requests/AtsJobsAddResponse.md)**

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

Get Job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats.jobsOne" method="get" path="/ats/jobs/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AtsJobsOneRequest req = new AtsJobsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Ats.Jobs.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [AtsJobsOneRequest](../../Models/Requests/AtsJobsOneRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[AtsJobsOneResponse](../../Models/Requests/AtsJobsOneResponse.md)**

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

Update Job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats.jobsUpdate" method="patch" path="/ats/jobs/{id}" -->
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

AtsJobsUpdateRequest req = new AtsJobsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Job = new JobInput() {
        Slug = "ceo",
        Title = "CEO",
        Sequence = 3,
        Visibility = Visibility.Internal,
        Status = JobStatus.Completed,
        Code = "123-OC",
        Language = "EN",
        EmploymentTerms = EmploymentTerms.FullTime,
        Experience = "Director/ Vice President",
        Location = "San Francisco",
        Remote = true,
        RequisitionId = "abc123",
        Department = new DepartmentInput() {
            Name = "R&D",
            Code = "2",
            Description = "R&D",
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
        Branch = new JobBranch() {
            Name = "HQ NY",
        },
        Recruiters = new List<string>() {
            "a0d636c6-43b3-4bde-8c70-85b707d992f4",
        },
        HiringManagers = new List<string>() {
            "123456",
        },
        Followers = new List<string>() {
            "a0d636c6-43b3-4bde-8c70-85b707d992f4",
            "a98lfd96-43b3-4bde-8c70-85b707d992e6",
        },
        Description = "A description",
        Blocks = new List<Blocks>() {
            new Blocks() {
                Title = "string",
                Content = "string",
            },
        },
        Closing = "The closing section of the job description",
        ClosingDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        Salary = new Salary() {
            Min = 8000,
            Max = 10000,
            Currency = Currency.Usd,
            Interval = "year",
        },
        Links = new List<JobLinks>() {
            new JobLinks() {
                Type = JobType.JobPortal,
                Url = "https://app.intercom.io/contacts/12345",
            },
        },
        Confidential = false,
        AvailableToEmployees = false,
        Tags = new List<string>() {
            "New",
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
        Deleted = true,
        OwnerId = "54321",
    },
};

var res = await sdk.Ats.Jobs.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [AtsJobsUpdateRequest](../../Models/Requests/AtsJobsUpdateRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[AtsJobsUpdateResponse](../../Models/Requests/AtsJobsUpdateResponse.md)**

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

Delete Job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats.jobsDelete" method="delete" path="/ats/jobs/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AtsJobsDeleteRequest req = new AtsJobsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Ats.Jobs.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [AtsJobsDeleteRequest](../../Models/Requests/AtsJobsDeleteRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[AtsJobsDeleteResponse](../../Models/Requests/AtsJobsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |