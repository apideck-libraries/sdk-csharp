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
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

IssueTrackingCollectionsAllRequest req = new IssueTrackingCollectionsAllRequest() {
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
    Sort = new CollectionsSort() {
        By = CollectionsSortBy.Name,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

IssueTrackingCollectionsAllResponse? res = await sdk.IssueTracking.Collections.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [IssueTrackingCollectionsAllRequest](../../Models/Requests/IssueTrackingCollectionsAllRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[IssueTrackingCollectionsAllResponse](../../Models/Requests/IssueTrackingCollectionsAllResponse.md)**

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

Get Collection

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

IssueTrackingCollectionsOneRequest req = new IssueTrackingCollectionsOneRequest() {
    CollectionId = "apideck-io",
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
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

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |