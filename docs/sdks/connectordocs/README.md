# ConnectorDocs
(*Connector.ConnectorDocs*)

## Overview

### Available Operations

* [Get](#get) - Get Connector Doc content

## Get

Get Connector Doc content

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

var res = await sdk.Connector.ConnectorDocs.GetAsync(
    id: "<id>",
    docId: "application_owner+oauth_credentials",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

// handle response
```

### Parameters

| Parameter                               | Type                                    | Required                                | Description                             | Example                                 |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `Id`                                    | *string*                                | :heavy_check_mark:                      | ID of the record you are acting upon.   |                                         |
| `DocId`                                 | *string*                                | :heavy_check_mark:                      | ID of the Doc                           | application_owner+oauth_credentials     |
| `AppId`                                 | *string*                                | :heavy_minus_sign:                      | The ID of your Unify application        | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX |

### Response

**[ConnectorConnectorDocsOneResponse](../../Models/Requests/ConnectorConnectorDocsOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |