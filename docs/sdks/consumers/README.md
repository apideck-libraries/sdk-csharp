# Consumers
(*Vault.Consumers*)

## Overview

### Available Operations

* [Create](#create) - Create consumer
* [List](#list) - Get all consumers
* [Get](#get) - Get consumer
* [Update](#update) - Update consumer
* [Delete](#delete) - Delete consumer

## Create

Create a consumer

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.consumersAdd" method="post" path="/vault/consumers" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Consumers.CreateAsync(createConsumerRequest: new CreateConsumerRequest() {
    ConsumerId = "test_consumer_id",
    Metadata = new ConsumerMetadata() {
        AccountName = "SpaceX",
        UserName = "Elon Musk",
        Email = "elon@musk.com",
        Image = "https://www.spacex.com/static/images/share.jpg",
    },
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `CreateConsumerRequest`                                                   | [CreateConsumerRequest](../../Models/Components/CreateConsumerRequest.md) | :heavy_check_mark:                                                        | N/A                                                                       |                                                                           |
| `AppId`                                                                   | *string*                                                                  | :heavy_minus_sign:                                                        | The ID of your Unify application                                          | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                   |

### Response

**[VaultConsumersAddResponse](../../Models/Requests/VaultConsumersAddResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## List

This endpoint includes all application consumers, along with an aggregated count of requests made.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.consumersAll" method="get" path="/vault/consumers" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

VaultConsumersAllResponse? res = await sdk.Vault.Consumers.ListAsync(limit: 20);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      | Example                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `AppId`                                                                                                          | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | The ID of your Unify application                                                                                 | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                                                          |
| `Cursor`                                                                                                         | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | Cursor to start from. You can find cursors for next/previous pages in the meta.cursors property of the response. |                                                                                                                  |
| `Limit`                                                                                                          | *long*                                                                                                           | :heavy_minus_sign:                                                                                               | Number of results to return. Minimum 1, Maximum 200, Default 20                                                  |                                                                                                                  |

### Response

**[VaultConsumersAllResponse](../../Models/Requests/VaultConsumersAllResponse.md)**

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

Consumer detail including their aggregated counts with the connections they have authorized.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.consumersOne" method="get" path="/vault/consumers/{consumer_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Consumers.GetAsync(consumerId: "test_user_id");

// handle response
```

### Parameters

| Parameter                               | Type                                    | Required                                | Description                             | Example                                 |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `ConsumerId`                            | *string*                                | :heavy_check_mark:                      | ID of the consumer to return            | test_user_id                            |
| `AppId`                                 | *string*                                | :heavy_minus_sign:                      | The ID of your Unify application        | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX |

### Response

**[VaultConsumersOneResponse](../../Models/Requests/VaultConsumersOneResponse.md)**

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

Update consumer metadata such as name and email.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.consumersUpdate" method="patch" path="/vault/consumers/{consumer_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Consumers.UpdateAsync(
    consumerId: "test_user_id",
    updateConsumerRequest: new UpdateConsumerRequest() {
        Metadata = new ConsumerMetadata() {
            AccountName = "SpaceX",
            UserName = "Elon Musk",
            Email = "elon@musk.com",
            Image = "https://www.spacex.com/static/images/share.jpg",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ConsumerId`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | ID of the consumer to return                                              | test_user_id                                                              |
| `UpdateConsumerRequest`                                                   | [UpdateConsumerRequest](../../Models/Components/UpdateConsumerRequest.md) | :heavy_check_mark:                                                        | N/A                                                                       |                                                                           |
| `AppId`                                                                   | *string*                                                                  | :heavy_minus_sign:                                                        | The ID of your Unify application                                          | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                   |

### Response

**[VaultConsumersUpdateResponse](../../Models/Requests/VaultConsumersUpdateResponse.md)**

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

Delete consumer and all their connections, including credentials.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.consumersDelete" method="delete" path="/vault/consumers/{consumer_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Vault.Consumers.DeleteAsync(consumerId: "test_user_id");

// handle response
```

### Parameters

| Parameter                               | Type                                    | Required                                | Description                             | Example                                 |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `ConsumerId`                            | *string*                                | :heavy_check_mark:                      | ID of the consumer to return            | test_user_id                            |
| `AppId`                                 | *string*                                | :heavy_minus_sign:                      | The ID of your Unify application        | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX |

### Response

**[VaultConsumersDeleteResponse](../../Models/Requests/VaultConsumersDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |