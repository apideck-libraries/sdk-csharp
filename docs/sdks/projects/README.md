# Projects
(*Accounting.Projects*)

## Overview

### Available Operations

* [List](#list) - List projects
* [Create](#create) - Create project
* [Get](#get) - Get project
* [Update](#update) - Update project
* [Delete](#delete) - Delete project

## List

List projects

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.projectsAll" method="get" path="/accounting/projects" -->
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

AccountingProjectsAllRequest req = new AccountingProjectsAllRequest() {
    ServiceId = "salesforce",
    Filter = new ProjectsFilter() {
        Name = "Website Redesign",
        Status = ProjectStatus.Active,
        CustomerId = "12345",
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
    },
    Sort = new ProjectsSort() {
        By = ProjectsSortSortBy.Name,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingProjectsAllResponse? res = await sdk.Accounting.Projects.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingProjectsAllRequest](../../Models/Requests/AccountingProjectsAllRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingProjectsAllResponse](../../Models/Requests/AccountingProjectsAllResponse.md)**

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

Create project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.projectsAdd" method="post" path="/accounting/projects" -->
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

AccountingProjectsAddRequest req = new AccountingProjectsAddRequest() {
    ServiceId = "salesforce",
    Project = new ProjectInput() {
        Name = "Website Redesign Project",
        DisplayId = "PROJ-001",
        ReferenceId = "WD-REF-2024-001",
        Description = "Complete redesign of the company website including new branding and improved user experience",
        Status = ProjectProjectStatus.Active,
        Active = true,
        ProjectType = ProjectType.ClientProject,
        Priority = Priority.High,
        CompletionPercentage = 75.5D,
        StartDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-01-15")),
        EndDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-06-30")),
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        Department = new ProjectDepartment() {
            Id = "DEPT-001",
            Name = "Marketing",
        },
        CompanyId = "12345",
        OwnerId = "12345",
        ParentProject = new ParentProject() {
            Id = "PROJ-PARENT-001",
            Name = "Company Website Overhaul",
        },
        Currency = Currency.Usd,
        BudgetAmount = 50000D,
        ApprovedAmount = 48000D,
        BudgetHours = 400D,
        HourlyRate = 125D,
        BillingMethod = BillingMethod.TimeAndMaterials,
        Phase = ProjectPhase.Execution,
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        Tags = new List<string>() {
            "website",
            "redesign",
            "urgent",
        },
        Notes = "Client has requested modern design with mobile-first approach",
        ContractNumber = "CNT-2024-001",
        ProfitMargin = 15.5D,
        ScheduleStatus = ScheduleStatus.OnSchedule,
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
        TeamSize = 8,
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateStr(
                    "Uses Salesforce and Marketo"
                ),
            },
        },
        RowVersion = "1-12345",
    },
};

var res = await sdk.Accounting.Projects.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingProjectsAddRequest](../../Models/Requests/AccountingProjectsAddRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingProjectsAddResponse](../../Models/Requests/AccountingProjectsAddResponse.md)**

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

Get project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.projectsOne" method="get" path="/accounting/projects/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingProjectsOneRequest req = new AccountingProjectsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Projects.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingProjectsOneRequest](../../Models/Requests/AccountingProjectsOneRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingProjectsOneResponse](../../Models/Requests/AccountingProjectsOneResponse.md)**

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

Update project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.projectsUpdate" method="patch" path="/accounting/projects/{id}" -->
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

AccountingProjectsUpdateRequest req = new AccountingProjectsUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Project = new ProjectInput() {
        Name = "Website Redesign Project",
        DisplayId = "PROJ-001",
        ReferenceId = "WD-REF-2024-001",
        Description = "Complete redesign of the company website including new branding and improved user experience",
        Status = ProjectProjectStatus.Active,
        Active = true,
        ProjectType = ProjectType.ClientProject,
        Priority = Priority.High,
        CompletionPercentage = 75.5D,
        StartDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-01-15")),
        EndDate = LocalDate.FromDateTime(System.DateTime.Parse("2024-06-30")),
        Customer = null,
        Department = new ProjectDepartment() {
            Id = "DEPT-001",
            Name = "Marketing",
        },
        CompanyId = "12345",
        OwnerId = "12345",
        ParentProject = new ParentProject() {
            Id = "PROJ-PARENT-001",
            Name = "Company Website Overhaul",
        },
        Currency = Currency.Usd,
        BudgetAmount = 50000D,
        ApprovedAmount = 48000D,
        BudgetHours = 400D,
        HourlyRate = 125D,
        BillingMethod = BillingMethod.TimeAndMaterials,
        Phase = ProjectPhase.Execution,
        TaxRate = new LinkedTaxRateInput() {
            Id = "123456",
            Rate = 10D,
        },
        TrackingCategories = new List<LinkedTrackingCategory?>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
                ParentId = "123456",
                ParentName = "New York",
            },
        },
        Tags = new List<string>() {
            "website",
            "redesign",
            "urgent",
        },
        Notes = "Client has requested modern design with mobile-first approach",
        ContractNumber = "CNT-2024-001",
        ProfitMargin = 15.5D,
        ScheduleStatus = ScheduleStatus.OnSchedule,
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
        TeamSize = 8,
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateStr(
                    "Uses Salesforce and Marketo"
                ),
            },
        },
        RowVersion = "1-12345",
    },
};

var res = await sdk.Accounting.Projects.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingProjectsUpdateRequest](../../Models/Requests/AccountingProjectsUpdateRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingProjectsUpdateResponse](../../Models/Requests/AccountingProjectsUpdateResponse.md)**

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

Delete project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.projectsDelete" method="delete" path="/accounting/projects/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingProjectsDeleteRequest req = new AccountingProjectsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Projects.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingProjectsDeleteRequest](../../Models/Requests/AccountingProjectsDeleteRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingProjectsDeleteResponse](../../Models/Requests/AccountingProjectsDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |