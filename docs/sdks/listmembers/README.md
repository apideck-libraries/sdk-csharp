# Crm.ListMembers

## Overview

### Available Operations

* [List](#list) - List list members

## List

Retrieve the records that belong to a List. Returns a paginated set of members, each carrying the downstream record `id` and its `object_type`. Use this to enumerate the contents of a List (for example the contacts or companies a HubSpot list contains) instead of dropping to the proxy.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm.listMembersAll" method="get" path="/crm/lists/{id}/members" -->
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

CrmListMembersAllRequest req = new CrmListMembersAllRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

CrmListMembersAllResponse? res = await sdk.Crm.ListMembers.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CrmListMembersAllRequest](../../Models/Requests/CrmListMembersAllRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[CrmListMembersAllResponse](../../Models/Requests/CrmListMembersAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |