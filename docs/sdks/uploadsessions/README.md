# UploadSessions
(*FileStorage.UploadSessions*)

## Overview

### Available Operations

* [Create](#create) - Start Upload Session
* [Get](#get) - Get Upload Session
* [Delete](#delete) - Abort Upload Session
* [Finish](#finish) - Finish Upload Session

## Create

Start an Upload Session. Upload sessions are used to upload large files, use the [Upload File](#operation/filesUpload) endpoint to upload smaller files (up to 100MB). Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using ApiDeckSdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

FileStorageUploadSessionsAddRequest req = new FileStorageUploadSessionsAddRequest() {
    CreateUploadSessionRequest = new CreateUploadSessionRequest() {
        Name = "Documents",
        ParentFolderId = "1234",
        DriveId = "1234",
        Size = 1810673,
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

var res = await sdk.FileStorage.UploadSessions.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [FileStorageUploadSessionsAddRequest](../../Models/Requests/FileStorageUploadSessionsAddRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |
| `serverURL`                                                                                         | *string*                                                                                            | :heavy_minus_sign:                                                                                  | An optional server URL to use.                                                                      |

### Response

**[FileStorageUploadSessionsAddResponse](../../Models/Requests/FileStorageUploadSessionsAddResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |

## Get

Get Upload Session. Use the `part_size` to split your file into parts. Upload the parts to the [Upload part of File](#operation/uploadSessionsUpload) endpoint. Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using ApiDeckSdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

FileStorageUploadSessionsOneRequest req = new FileStorageUploadSessionsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.FileStorage.UploadSessions.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [FileStorageUploadSessionsOneRequest](../../Models/Requests/FileStorageUploadSessionsOneRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |
| `serverURL`                                                                                         | *string*                                                                                            | :heavy_minus_sign:                                                                                  | An optional server URL to use.                                                                      |

### Response

**[FileStorageUploadSessionsOneResponse](../../Models/Requests/FileStorageUploadSessionsOneResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |

## Delete

Abort Upload Session. Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using ApiDeckSdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

FileStorageUploadSessionsDeleteRequest req = new FileStorageUploadSessionsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.FileStorage.UploadSessions.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [FileStorageUploadSessionsDeleteRequest](../../Models/Requests/FileStorageUploadSessionsDeleteRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[FileStorageUploadSessionsDeleteResponse](../../Models/Requests/FileStorageUploadSessionsDeleteResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |

## Finish

Finish Upload Session. Only call this endpoint after all File parts have been uploaded to [Upload part of File](#operation/uploadSessionsUpload). Note that the base URL is upload.apideck.com instead of unify.apideck.com. For more information on uploads, refer to the [file upload guide](/guides/file-upload).

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using ApiDeckSdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

FileStorageUploadSessionsFinishRequest req = new FileStorageUploadSessionsFinishRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Digest = "sha=fpRyg5eVQletdZqEKaFlqwBXJzM=",
};

var res = await sdk.FileStorage.UploadSessions.FinishAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [FileStorageUploadSessionsFinishRequest](../../Models/Requests/FileStorageUploadSessionsFinishRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |
| `serverURL`                                                                                               | *string*                                                                                                  | :heavy_minus_sign:                                                                                        | An optional server URL to use.                                                                            |

### Response

**[FileStorageUploadSessionsFinishResponse](../../Models/Requests/FileStorageUploadSessionsFinishResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |