# Webhooks
(*Webhook.Webhooks*)

## Overview

### Available Operations

* [List](#list) - List webhook subscriptions
* [Create](#create) - Create webhook subscription
* [Get](#get) - Get webhook subscription
* [Update](#update) - Update webhook subscription
* [Delete](#delete) - Delete webhook subscription

## List

List all webhook subscriptions

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Webhook.Webhooks.ListAsync(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    cursor: "<value>",
    limit: 20
);

// handle response
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      | Example                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `AppId`                                                                                                          | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | The ID of your Unify application                                                                                 | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                                                          |
| `Cursor`                                                                                                         | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. |                                                                                                                  |
| `Limit`                                                                                                          | *long*                                                                                                           | :heavy_minus_sign:                                                                                               | Number of results to return. Minimum 1, Maximum 200, Default 20                                                  |                                                                                                                  |

### Response

**[WebhookWebhooksAllResponse](../../Models/Requests/WebhookWebhooksAllResponse.md)**

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

Create a webhook subscription to receive events

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Webhook.Webhooks.CreateAsync(
    createWebhookRequest: new CreateWebhookRequest() {
        Description = "A description",
        UnifiedApi = ApideckUnifySdk.Models.Components.UnifiedApiId.Crm,
        Status = ApideckUnifySdk.Models.Components.Status.Enabled,
        DeliveryUrl = "https://example.com/my/webhook/endpoint",
        Events = new List<WebhookEventType>() {
            ApideckUnifySdk.Models.Components.WebhookEventType.VaultConnectionCreated,
            ApideckUnifySdk.Models.Components.WebhookEventType.VaultConnectionUpdated,
        },
    },
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `CreateWebhookRequest`                                                  | [CreateWebhookRequest](../../Models/Components/CreateWebhookRequest.md) | :heavy_check_mark:                                                      | N/A                                                                     |                                                                         |
| `AppId`                                                                 | *string*                                                                | :heavy_minus_sign:                                                      | The ID of your Unify application                                        | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                 |

### Response

**[WebhookWebhooksAddResponse](../../Models/Requests/WebhookWebhooksAddResponse.md)**

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

Get the webhook subscription details

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Webhook.Webhooks.GetAsync(
    id: "<id>",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Id`                                                                                               | *string*                                                                                           | :heavy_check_mark:                                                                                 | JWT Webhook token that represents the unifiedApi and applicationId associated to the event source. |                                                                                                    |
| `AppId`                                                                                            | *string*                                                                                           | :heavy_minus_sign:                                                                                 | The ID of your Unify application                                                                   | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                                            |

### Response

**[WebhookWebhooksOneResponse](../../Models/Requests/WebhookWebhooksOneResponse.md)**

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

Update a webhook subscription

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Webhook.Webhooks.UpdateAsync(
    id: "<id>",
    updateWebhookRequest: new UpdateWebhookRequest() {
        Description = "A description",
        Status = ApideckUnifySdk.Models.Components.Status.Enabled,
        DeliveryUrl = "https://example.com/my/webhook/endpoint",
        Events = new List<WebhookEventType>() {
            ApideckUnifySdk.Models.Components.WebhookEventType.VaultConnectionCreated,
            ApideckUnifySdk.Models.Components.WebhookEventType.VaultConnectionUpdated,
        },
    },
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Id`                                                                                               | *string*                                                                                           | :heavy_check_mark:                                                                                 | JWT Webhook token that represents the unifiedApi and applicationId associated to the event source. |                                                                                                    |
| `UpdateWebhookRequest`                                                                             | [UpdateWebhookRequest](../../Models/Components/UpdateWebhookRequest.md)                            | :heavy_check_mark:                                                                                 | N/A                                                                                                |                                                                                                    |
| `AppId`                                                                                            | *string*                                                                                           | :heavy_minus_sign:                                                                                 | The ID of your Unify application                                                                   | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                                            |

### Response

**[WebhookWebhooksUpdateResponse](../../Models/Requests/WebhookWebhooksUpdateResponse.md)**

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

Delete a webhook subscription

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Requests;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Webhook.Webhooks.DeleteAsync(
    id: "<id>",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Id`                                                                                               | *string*                                                                                           | :heavy_check_mark:                                                                                 | JWT Webhook token that represents the unifiedApi and applicationId associated to the event source. |                                                                                                    |
| `AppId`                                                                                            | *string*                                                                                           | :heavy_minus_sign:                                                                                 | The ID of your Unify application                                                                   | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                                            |

### Response

**[WebhookWebhooksDeleteResponse](../../Models/Requests/WebhookWebhooksDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |