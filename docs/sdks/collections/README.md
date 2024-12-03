# Collections
(*IssueTracking.Collections*)

## Overview

### Available Operations

* [List](#list) - List Collections
* [Get](#get) - Get Collection

## List

List Collections

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

IssueTrackingCollectionsAllRequest req = new IssueTrackingCollectionsAllRequest() {
    ServiceId = "salesforce",
    Sort = new CollectionsSort() {
        By = Unify.Models.Components.CollectionsSortBy.Name,
        Direction = Unify.Models.Components.SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.IssueTracking.Collections.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [IssueTrackingCollectionsAllRequest](../../Models/Requests/IssueTrackingCollectionsAllRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[IssueTrackingCollectionsAllResponse](../../Models/Requests/IssueTrackingCollectionsAllResponse.md)**

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

Get Collection

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

IssueTrackingCollectionsOneRequest req = new IssueTrackingCollectionsOneRequest() {
    CollectionId = "apideck-io",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.IssueTracking.Collections.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [IssueTrackingCollectionsOneRequest](../../Models/Requests/IssueTrackingCollectionsOneRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[IssueTrackingCollectionsOneResponse](../../Models/Requests/IssueTrackingCollectionsOneResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |