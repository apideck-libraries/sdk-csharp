# Activities
(*Crm.Activities*)

## Overview

### Available Operations

* [List](#list) - List activities
* [Create](#create) - Create activity
* [Get](#get) - Get activity
* [Update](#update) - Update activity
* [Delete](#delete) - Delete activity

## List

List activities

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

CrmActivitiesAllRequest req = new CrmActivitiesAllRequest() {
    ServiceId = "salesforce",
    Filter = new ActivitiesFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
    },
    Sort = new ActivitiesSort() {
        By = Unify.Models.Components.ActivitiesSortBy.CreatedAt,
        Direction = Unify.Models.Components.SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Crm.Activities.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [CrmActivitiesAllRequest](../../Models/Requests/CrmActivitiesAllRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CrmActivitiesAllResponse](../../Models/Requests/CrmActivitiesAllResponse.md)**

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

Create activity

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

CrmActivitiesAddRequest req = new CrmActivitiesAddRequest() {
    Activity = new ActivityInput() {
        ActivityDatetime = "2021-05-01T12:00:00.000Z",
        DurationSeconds = 1800,
        UserId = "12345",
        AccountId = "12345",
        ContactId = "12345",
        CompanyId = "12345",
        OpportunityId = "12345",
        LeadId = "12345",
        OwnerId = "12345",
        CampaignId = "12345",
        CaseId = "12345",
        AssetId = "12345",
        ContractId = "12345",
        ProductId = "12345",
        SolutionId = "12345",
        CustomObjectId = "12345",
        Type = Unify.Models.Components.ActivityType.Meeting,
        Title = "Meeting",
        Description = "More info about the meeting",
        Note = "An internal note about the meeting",
        Location = "Space",
        LocationAddress = new Address() {
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
        AllDayEvent = false,
        Private = true,
        GroupEvent = true,
        EventSubType = "debrief",
        GroupEventType = "Proposed",
        Child = false,
        Archived = false,
        Deleted = false,
        ShowAs = Unify.Models.Components.ShowAs.Busy,
        Done = false,
        StartDatetime = "2021-05-01T12:00:00.000Z",
        EndDatetime = "2021-05-01T12:30:00.000Z",
        ActivityDate = "2021-05-01",
        EndDate = "2021-05-01",
        Recurrent = false,
        ReminderDatetime = "2021-05-01T17:00:00.000Z",
        ReminderSet = false,
        VideoConferenceUrl = "https://us02web.zoom.us/j/88120759396",
        VideoConferenceId = "zoom:88120759396",
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
        Attendees = new List<ActivityAttendeeInput>() {
            new ActivityAttendeeInput() {
                Name = "Elon Musk",
                FirstName = "Elon",
                MiddleName = "D.",
                LastName = "Musk",
                Prefix = "Mr.",
                Suffix = "PhD",
                EmailAddress = "elon@musk.com",
                IsOrganizer = true,
                Status = Unify.Models.Components.ActivityAttendeeStatus.Accepted,
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
    },
    ServiceId = "salesforce",
};

var res = await sdk.Crm.Activities.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [CrmActivitiesAddRequest](../../Models/Requests/CrmActivitiesAddRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CrmActivitiesAddResponse](../../Models/Requests/CrmActivitiesAddResponse.md)**

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

Get activity

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

CrmActivitiesOneRequest req = new CrmActivitiesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Crm.Activities.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [CrmActivitiesOneRequest](../../Models/Requests/CrmActivitiesOneRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CrmActivitiesOneResponse](../../Models/Requests/CrmActivitiesOneResponse.md)**

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

Update activity

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

CrmActivitiesUpdateRequest req = new CrmActivitiesUpdateRequest() {
    Id = "<id>",
    Activity = new ActivityInput() {
        ActivityDatetime = "2021-05-01T12:00:00.000Z",
        DurationSeconds = 1800,
        UserId = "12345",
        AccountId = "12345",
        ContactId = "12345",
        CompanyId = "12345",
        OpportunityId = "12345",
        LeadId = "12345",
        OwnerId = "12345",
        CampaignId = "12345",
        CaseId = "12345",
        AssetId = "12345",
        ContractId = "12345",
        ProductId = "12345",
        SolutionId = "12345",
        CustomObjectId = "12345",
        Type = Unify.Models.Components.ActivityType.Meeting,
        Title = "Meeting",
        Description = "More info about the meeting",
        Note = "An internal note about the meeting",
        Location = "Space",
        LocationAddress = new Address() {
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
        AllDayEvent = false,
        Private = true,
        GroupEvent = true,
        EventSubType = "debrief",
        GroupEventType = "Proposed",
        Child = false,
        Archived = false,
        Deleted = false,
        ShowAs = Unify.Models.Components.ShowAs.Busy,
        Done = false,
        StartDatetime = "2021-05-01T12:00:00.000Z",
        EndDatetime = "2021-05-01T12:30:00.000Z",
        ActivityDate = "2021-05-01",
        EndDate = "2021-05-01",
        Recurrent = false,
        ReminderDatetime = "2021-05-01T17:00:00.000Z",
        ReminderSet = false,
        VideoConferenceUrl = "https://us02web.zoom.us/j/88120759396",
        VideoConferenceId = "zoom:88120759396",
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
        Attendees = new List<ActivityAttendeeInput>() {
            new ActivityAttendeeInput() {
                Name = "Elon Musk",
                FirstName = "Elon",
                MiddleName = "D.",
                LastName = "Musk",
                Prefix = "Mr.",
                Suffix = "PhD",
                EmailAddress = "elon@musk.com",
                IsOrganizer = true,
                Status = Unify.Models.Components.ActivityAttendeeStatus.Accepted,
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
    },
    ServiceId = "salesforce",
};

var res = await sdk.Crm.Activities.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CrmActivitiesUpdateRequest](../../Models/Requests/CrmActivitiesUpdateRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CrmActivitiesUpdateResponse](../../Models/Requests/CrmActivitiesUpdateResponse.md)**

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

Delete activity

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

CrmActivitiesDeleteRequest req = new CrmActivitiesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Crm.Activities.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CrmActivitiesDeleteRequest](../../Models/Requests/CrmActivitiesDeleteRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CrmActivitiesDeleteResponse](../../Models/Requests/CrmActivitiesDeleteResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |