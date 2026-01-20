# Ecommerce.Stores

## Overview

### Available Operations

* [Get](#get) - Get Store

## Get

Get Store

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ecommerce.storesOne" method="get" path="/ecommerce/store" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

EcommerceStoresOneRequest req = new EcommerceStoresOneRequest() {
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Ecommerce.Stores.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [EcommerceStoresOneRequest](../../Models/Requests/EcommerceStoresOneRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[EcommerceStoresOneResponse](../../Models/Requests/EcommerceStoresOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |