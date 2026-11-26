# Accounting.GoodsReceipts

## Overview

### Available Operations

* [List](#list) - List Goods Receipts
* [Create](#create) - Create Goods Receipt
* [Get](#get) - Get Goods Receipt

## List

List Goods Receipts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.goodsReceiptsAll" method="get" path="/accounting/goods-receipts" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingGoodsReceiptsAllRequest req = new AccountingGoodsReceiptsAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Filter = new GoodsReceiptsFilter() {
        UpdatedSince = System.DateTime.Parse("2026-09-01T07:43:32.000Z").ToUniversalTime(),
        SupplierId = "123abc",
        PurchaseOrderId = "123456",
    },
    Sort = new GoodsReceiptsSort() {
        By = GoodsReceiptsSortBy.UpdatedAt,
        Direction = SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingGoodsReceiptsAllResponse? res = await sdk.Accounting.GoodsReceipts.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingGoodsReceiptsAllRequest](../../Models/Requests/AccountingGoodsReceiptsAllRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingGoodsReceiptsAllResponse](../../Models/Requests/AccountingGoodsReceiptsAllResponse.md)**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| ApideckUnifySdk.Models.Errors.BadRequestResponse       | 400                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse     | 401                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse  | 402                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.NotFoundResponse         | 404                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.MethodNotAllowedResponse | 405                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse    | 422                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.APIException             | 4XX, 5XX                                               | \*/\*                                                  |

## Create

Create a Goods Receipt against a purchase order. `purchase_order_id` is required and every line names the purchase order line it receives against; a receipt that is not tied to a purchase order cannot be created. The response returns the `id` of the new receipt only: read it with `GET /accounting/goods-receipts/{id}` to see the posted document.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.goodsReceiptsAdd" method="post" path="/accounting/goods-receipts" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingGoodsReceiptsAddRequest req = new AccountingGoodsReceiptsAddRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    GoodsReceiptCreateInput = new GoodsReceiptCreateInput() {
        PurchaseOrderId = "4500000004",
        ReceivedDate = LocalDate.FromDateTime(System.DateTime.Parse("2026-09-01")),
        PostedDate = LocalDate.FromDateTime(System.DateTime.Parse("2026-09-01")),
        Reference = "DN-78910",
        Notes = "Partial delivery, remainder expected next week.",
        LocationId = "1710/171A",
        LineItems = new List<GoodsReceiptLineCreateInput>() {},
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
};

var res = await sdk.Accounting.GoodsReceipts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingGoodsReceiptsAddRequest](../../Models/Requests/AccountingGoodsReceiptsAddRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingGoodsReceiptsAddResponse](../../Models/Requests/AccountingGoodsReceiptsAddResponse.md)**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| ApideckUnifySdk.Models.Errors.BadRequestResponse       | 400                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse     | 401                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse  | 402                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.NotFoundResponse         | 404                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.MethodNotAllowedResponse | 405                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse    | 422                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.APIException             | 4XX, 5XX                                               | \*/\*                                                  |

## Get

Get Goods Receipt

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.goodsReceiptsOne" method="get" path="/accounting/goods-receipts/{id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingGoodsReceiptsOneRequest req = new AccountingGoodsReceiptsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    CompanyId = "12345",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.GoodsReceipts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [AccountingGoodsReceiptsOneRequest](../../Models/Requests/AccountingGoodsReceiptsOneRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[AccountingGoodsReceiptsOneResponse](../../Models/Requests/AccountingGoodsReceiptsOneResponse.md)**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| ApideckUnifySdk.Models.Errors.BadRequestResponse       | 400                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse     | 401                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse  | 402                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.NotFoundResponse         | 404                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.MethodNotAllowedResponse | 405                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse    | 422                                                    | application/json                                       |
| ApideckUnifySdk.Models.Errors.APIException             | 4XX, 5XX                                               | \*/\*                                                  |