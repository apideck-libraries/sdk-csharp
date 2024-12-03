# ValidateConnection
(*Vault.ValidateConnection*)

## Overview

### Available Operations

* [State](#state) - Validate Connection State

## State

This endpoint validates the current state of a given connection. This will perform different checks based on the connection auth type. For basic and apiKey auth types, the presence of required fields is checked.
For connectors that implement OAuth2, this operation forces the refresh flow for an access token regardless of its expiry.

Note:
  - Do not include any credentials in the request body. This operation does not persist changes, but only triggers the validation of connection state.
  - If a refresh token flow was performed and successful, the new access token will then be used for subsequent API requests.


### Example Usage

```csharp
using Unify;
using Unify.Models.Requests;
using Unify.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

VaultValidateConnectionStateRequest req = new VaultValidateConnectionStateRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
};

var res = await sdk.Vault.ValidateConnection.StateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [VaultValidateConnectionStateRequest](../../Models/Requests/VaultValidateConnectionStateRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[VaultValidateConnectionStateResponse](../../Models/Requests/VaultValidateConnectionStateResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Unify.Models.Errors.BadRequestResponse      | 400                                         | application/json                            |
| Unify.Models.Errors.UnauthorizedResponse    | 401                                         | application/json                            |
| Unify.Models.Errors.PaymentRequiredResponse | 402                                         | application/json                            |
| Unify.Models.Errors.NotFoundResponse        | 404                                         | application/json                            |
| Unify.Models.Errors.UnprocessableResponse   | 422                                         | application/json                            |
| Unify.Models.Errors.APIException            | 4XX, 5XX                                    | \*/\*                                       |