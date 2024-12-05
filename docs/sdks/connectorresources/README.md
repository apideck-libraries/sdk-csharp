# ConnectorResources
(*Connector.ConnectorResources*)

## Overview

### Available Operations

* [Get](#get) - Get Connector Resource

## Get

Get Connector Resource

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Connector.ConnectorResources.GetAsync(
    id: "<id>",
    resourceId: "<id>",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    unifiedApi: Apideck.Unify.SDK.Models.Components.UnifiedApiId.Crm
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             | Example                                                                                                 |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the record you are acting upon.                                                                   |                                                                                                         |
| `ResourceId`                                                                                            | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the resource you are acting upon.                                                                 |                                                                                                         |
| `AppId`                                                                                                 | *string*                                                                                                | :heavy_minus_sign:                                                                                      | The ID of your Unify application                                                                        | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                                                                 |
| `UnifiedApi`                                                                                            | [UnifiedApiId](../../Models/Components/UnifiedApiId.md)                                                 | :heavy_minus_sign:                                                                                      | Specify unified API for the connector resource. This is useful when a resource appears in multiple APIs | crm                                                                                                     |

### Response

**[ConnectorConnectorResourcesOneResponse](../../Models/Requests/ConnectorConnectorResourcesOneResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |