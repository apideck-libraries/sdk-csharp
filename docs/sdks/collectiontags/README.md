# CollectionTags
(*IssueTracking.CollectionTags*)

## Overview

### Available Operations

* [List](#list) - List Tags

## List

List Tags

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

IssueTrackingCollectionTagsAllRequest req = new IssueTrackingCollectionTagsAllRequest() {
    CollectionId = "apideck-io",
    ConsumerId = "test-consumer",
    AppId = "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

IssueTrackingCollectionTagsAllResponse? res = await sdk.IssueTracking.CollectionTags.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [IssueTrackingCollectionTagsAllRequest](../../Models/Requests/IssueTrackingCollectionTagsAllRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[IssueTrackingCollectionTagsAllResponse](../../Models/Requests/IssueTrackingCollectionTagsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |