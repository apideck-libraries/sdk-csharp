# CollectionTags
(*IssueTracking.CollectionTags*)

## Overview

### Available Operations

* [List](#list) - List Tags

## List

List Tags

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using System.Collections.Generic;
using ApiDeckSdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

IssueTrackingCollectionTagsAllRequest req = new IssueTrackingCollectionTagsAllRequest() {
    CollectionId = "apideck-io",
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.IssueTracking.CollectionTags.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [IssueTrackingCollectionTagsAllRequest](../../Models/Requests/IssueTrackingCollectionTagsAllRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[IssueTrackingCollectionTagsAllResponse](../../Models/Requests/IssueTrackingCollectionTagsAllResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |