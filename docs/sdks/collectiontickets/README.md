# CollectionTickets
(*IssueTracking.CollectionTickets*)

## Overview

### Available Operations

* [List](#list) - List Tickets
* [Create](#create) - Create Ticket
* [Get](#get) - Get Ticket
* [Update](#update) - Update Ticket
* [Delete](#delete) - Delete Ticket

## List

List Tickets

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

IssueTrackingCollectionTicketsAllRequest req = new IssueTrackingCollectionTicketsAllRequest() {
    CollectionId = "apideck-io",
    ServiceId = "salesforce",
    Sort = new TicketsSort() {
        By = Unify.Models.Components.TicketsSortBy.CreatedAt,
        Direction = Unify.Models.Components.SortDirection.Desc,
    },
    Filter = new IssuesFilter() {
        Status = new List<string>() {
            "open",
        },
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.IssueTracking.CollectionTickets.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [IssueTrackingCollectionTicketsAllRequest](../../Models/Requests/IssueTrackingCollectionTicketsAllRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[IssueTrackingCollectionTicketsAllResponse](../../Models/Requests/IssueTrackingCollectionTicketsAllResponse.md)**

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

Create Ticket

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

IssueTrackingCollectionTicketsAddRequest req = new IssueTrackingCollectionTicketsAddRequest() {
    CollectionId = "apideck-io",
    Ticket = new TicketInput() {
        ParentId = "12345",
        Type = "Technical",
        Subject = "Technical Support Request",
        Description = "I am facing issues with my internet connection",
        Status = "open",
        Priority = Unify.Models.Components.Priority.High,
        Assignees = new List<AssigneeInput>() {
            new AssigneeInput() {
                Id = "12345",
            },
        },
        DueDate = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        Tags = new List<CollectionTagInput>() {
            new CollectionTagInput() {
                Id = "12345",
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

var res = await sdk.IssueTracking.CollectionTickets.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [IssueTrackingCollectionTicketsAddRequest](../../Models/Requests/IssueTrackingCollectionTicketsAddRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[IssueTrackingCollectionTicketsAddResponse](../../Models/Requests/IssueTrackingCollectionTicketsAddResponse.md)**

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

Get Ticket

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

IssueTrackingCollectionTicketsOneRequest req = new IssueTrackingCollectionTicketsOneRequest() {
    TicketId = "<id>",
    CollectionId = "apideck-io",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.IssueTracking.CollectionTickets.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [IssueTrackingCollectionTicketsOneRequest](../../Models/Requests/IssueTrackingCollectionTicketsOneRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[IssueTrackingCollectionTicketsOneResponse](../../Models/Requests/IssueTrackingCollectionTicketsOneResponse.md)**

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

Update Ticket

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

IssueTrackingCollectionTicketsUpdateRequest req = new IssueTrackingCollectionTicketsUpdateRequest() {
    TicketId = "<id>",
    CollectionId = "apideck-io",
    Ticket = new TicketInput() {
        ParentId = "12345",
        Type = "Technical",
        Subject = "Technical Support Request",
        Description = "I am facing issues with my internet connection",
        Status = "open",
        Priority = Unify.Models.Components.Priority.High,
        Assignees = new List<AssigneeInput>() {
            new AssigneeInput() {
                Id = "12345",
            },
        },
        DueDate = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
        Tags = new List<CollectionTagInput>() {
            new CollectionTagInput() {
                Id = "12345",
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

var res = await sdk.IssueTracking.CollectionTickets.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [IssueTrackingCollectionTicketsUpdateRequest](../../Models/Requests/IssueTrackingCollectionTicketsUpdateRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[IssueTrackingCollectionTicketsUpdateResponse](../../Models/Requests/IssueTrackingCollectionTicketsUpdateResponse.md)**

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

Delete Ticket

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

IssueTrackingCollectionTicketsDeleteRequest req = new IssueTrackingCollectionTicketsDeleteRequest() {
    TicketId = "<id>",
    CollectionId = "apideck-io",
    ServiceId = "salesforce",
};

var res = await sdk.IssueTracking.CollectionTickets.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [IssueTrackingCollectionTicketsDeleteRequest](../../Models/Requests/IssueTrackingCollectionTicketsDeleteRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[IssueTrackingCollectionTicketsDeleteResponse](../../Models/Requests/IssueTrackingCollectionTicketsDeleteResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |