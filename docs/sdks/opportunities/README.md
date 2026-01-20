# Crm.Opportunities

## Overview

### Available Operations

* [List](#list) - List opportunities
* [Create](#create) - Create opportunity
* [Get](#get) - Get opportunity
* [Update](#update) - Update opportunity
* [Delete](#delete) - Delete opportunity

## List

List opportunities

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.opportunitiesAll" method="get" path="/crm/opportunities" -->
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

CrmOpportunitiesAllRequest req = new CrmOpportunitiesAllRequest() {
    ServiceId = "salesforce",
    Filter = new OpportunitiesFilter() {
        Status = "Completed",
        MonetaryAmount = 75000D,
    },
    Sort = new OpportunitiesSort() {
        By = OpportunitiesSortBy.CreatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

CrmOpportunitiesAllResponse? res = await sdk.Crm.Opportunities.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CrmOpportunitiesAllRequest](../../Models/Requests/CrmOpportunitiesAllRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CrmOpportunitiesAllResponse](../../Models/Requests/CrmOpportunitiesAllResponse.md)**

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

Create opportunity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.opportunitiesAdd" method="post" path="/crm/opportunities" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

CrmOpportunitiesAddRequest req = new CrmOpportunitiesAddRequest() {
    ServiceId = "salesforce",
    Opportunity = new OpportunityInput() {
        Title = "New Rocket",
        PrimaryContactId = "12345",
        Description = "Opportunities are created for People and Companies that are interested in buying your products or services. Create Opportunities for People and Companies to move them through one of your Pipelines.",
        Type = "Existing Customer - Upgrade",
        MonetaryAmount = 75000D,
        Currency = Currency.Usd,
        WinProbability = 40D,
        CloseDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        LossReasonId = "12345",
        LossReason = "No budget",
        WonReasonId = "12345",
        WonReason = "Best pitch",
        PipelineId = "12345",
        PipelineStageId = "12345",
        SourceId = "12345",
        LeadId = "12345",
        LeadSource = "Website",
        ContactId = "12345",
        ContactIds = new List<string>() {
            "12345",
        },
        CompanyId = "12345",
        CompanyName = "Copper",
        OwnerId = "12345",
        Priority = "None",
        Status = "Open",
        StatusId = "12345",
        Tags = new List<string>() {
            "New",
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
        StageLastChangedAt = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
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

var res = await sdk.Crm.Opportunities.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CrmOpportunitiesAddRequest](../../Models/Requests/CrmOpportunitiesAddRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CrmOpportunitiesAddResponse](../../Models/Requests/CrmOpportunitiesAddResponse.md)**

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

Get opportunity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.opportunitiesOne" method="get" path="/crm/opportunities/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

CrmOpportunitiesOneRequest req = new CrmOpportunitiesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Crm.Opportunities.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CrmOpportunitiesOneRequest](../../Models/Requests/CrmOpportunitiesOneRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CrmOpportunitiesOneResponse](../../Models/Requests/CrmOpportunitiesOneResponse.md)**

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

Update opportunity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.opportunitiesUpdate" method="patch" path="/crm/opportunities/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

CrmOpportunitiesUpdateRequest req = new CrmOpportunitiesUpdateRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Opportunity = new OpportunityInput() {
        Title = "New Rocket",
        PrimaryContactId = "12345",
        Description = "Opportunities are created for People and Companies that are interested in buying your products or services. Create Opportunities for People and Companies to move them through one of your Pipelines.",
        Type = "Existing Customer - Upgrade",
        MonetaryAmount = 75000D,
        Currency = Currency.Usd,
        WinProbability = 40D,
        CloseDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-10-30")),
        LossReasonId = "12345",
        LossReason = "No budget",
        WonReasonId = "12345",
        WonReason = "Best pitch",
        PipelineId = "12345",
        PipelineStageId = "12345",
        SourceId = "12345",
        LeadId = "12345",
        LeadSource = "Website",
        ContactId = "12345",
        ContactIds = new List<string>() {
            "12345",
        },
        CompanyId = "12345",
        CompanyName = "Copper",
        OwnerId = "12345",
        Priority = "None",
        Status = "Open",
        StatusId = "12345",
        Tags = new List<string>() {
            "New",
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
        StageLastChangedAt = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
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

var res = await sdk.Crm.Opportunities.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [CrmOpportunitiesUpdateRequest](../../Models/Requests/CrmOpportunitiesUpdateRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[CrmOpportunitiesUpdateResponse](../../Models/Requests/CrmOpportunitiesUpdateResponse.md)**

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

Delete opportunity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.opportunitiesDelete" method="delete" path="/crm/opportunities/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

CrmOpportunitiesDeleteRequest req = new CrmOpportunitiesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Crm.Opportunities.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [CrmOpportunitiesDeleteRequest](../../Models/Requests/CrmOpportunitiesDeleteRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[CrmOpportunitiesDeleteResponse](../../Models/Requests/CrmOpportunitiesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |