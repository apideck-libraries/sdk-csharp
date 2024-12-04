# CreateCallback
(*Vault.CreateCallback*)

## Overview

### Available Operations

* [State](#state) - Create Callback State

## State

This endpoint creates a callback state that can be used to issue requests to the callback endpoint.


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

VaultCreateCallbackStateRequest req = new VaultCreateCallbackStateRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
    CreateCallbackState = new CreateCallbackState() {
        RedirectUri = "https://example.com/callback",
    },
};

var res = await sdk.Vault.CreateCallback.StateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [VaultCreateCallbackStateRequest](../../Models/Requests/VaultCreateCallbackStateRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[VaultCreateCallbackStateResponse](../../Models/Requests/VaultCreateCallbackStateResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |