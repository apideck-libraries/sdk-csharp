# Connector.ConnectorResources

## Overview

### Available Operations

* [Get](#get) - Get Connector Resource

## Get

Get Connector Resource

### Example Usage

<!-- UsageSnippet language="csharp" operationID="connector.connectorResourcesOne" method="get" path="/connector/connectors/{id}/resources/{resource_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;

var sdk = new Apideck(
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Connector.ConnectorResources.GetAsync(
    id: "<id>",
    resourceId: "<id>",
    unifiedApi: UnifiedApiId.Crm
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

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |