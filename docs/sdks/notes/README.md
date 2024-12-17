# Notes
(*Crm.Notes*)

## Overview

### Available Operations

* [List](#list) - List notes
* [Create](#create) - Create note
* [Get](#get) - Get note
* [Update](#update) - Update note
* [Delete](#delete) - Delete note

## List

List notes

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

CrmNotesAllRequest req = new CrmNotesAllRequest() {
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Crm.Notes.ListAsync(req);

while(true)
{
    // handle items

    res = await res.Next();
    if (res == null)
    {
        break;
    }
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CrmNotesAllRequest](../../Models/Requests/CrmNotesAllRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CrmNotesAllResponse](../../Models/Requests/CrmNotesAllResponse.md)**

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

Create note

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

CrmNotesAddRequest req = new CrmNotesAddRequest() {
    Note = new NoteInput() {
        Title = "Meeting Notes",
        Content = "Office hours are 9AM-6PM",
        OwnerId = "12345",
        ContactId = "12345",
        CompanyId = "12345",
        OpportunityId = "12345",
        LeadId = "12345",
        Active = true,
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

var res = await sdk.Crm.Notes.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CrmNotesAddRequest](../../Models/Requests/CrmNotesAddRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CrmNotesAddResponse](../../Models/Requests/CrmNotesAddResponse.md)**

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

Get note

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

CrmNotesOneRequest req = new CrmNotesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Crm.Notes.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CrmNotesOneRequest](../../Models/Requests/CrmNotesOneRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CrmNotesOneResponse](../../Models/Requests/CrmNotesOneResponse.md)**

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

Update note

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

CrmNotesUpdateRequest req = new CrmNotesUpdateRequest() {
    Id = "<id>",
    Note = new NoteInput() {
        Title = "Meeting Notes",
        Content = "Office hours are 9AM-6PM",
        OwnerId = "12345",
        ContactId = "12345",
        CompanyId = "12345",
        OpportunityId = "12345",
        LeadId = "12345",
        Active = true,
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

var res = await sdk.Crm.Notes.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CrmNotesUpdateRequest](../../Models/Requests/CrmNotesUpdateRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CrmNotesUpdateResponse](../../Models/Requests/CrmNotesUpdateResponse.md)**

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

Delete note

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

CrmNotesDeleteRequest req = new CrmNotesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Crm.Notes.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CrmNotesDeleteRequest](../../Models/Requests/CrmNotesDeleteRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CrmNotesDeleteResponse](../../Models/Requests/CrmNotesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |