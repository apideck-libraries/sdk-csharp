# ConnectionConsent
(*Vault.ConnectionConsent*)

## Overview

### Available Operations

* [Update](#update) - Update consent state

## Update

Update the consent state of a connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="vault.connectionConsentUpdate" method="patch" path="/vault/connections/{unified_api}/{service_id}/consent" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

VaultConnectionConsentUpdateRequest req = new VaultConnectionConsentUpdateRequest() {
    ServiceId = "pipedrive",
    UnifiedApi = "crm",
    UpdateConsentRequest = new UpdateConsentRequest() {
        Resources = UpdateConsentRequestResources.CreateTwo(
            ApideckUnifySdk.Models.Components.Two.Wildcard
        ),
        Granted = true,
    },
};

var res = await sdk.Vault.ConnectionConsent.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [VaultConnectionConsentUpdateRequest](../../Models/Requests/VaultConnectionConsentUpdateRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[VaultConnectionConsentUpdateResponse](../../Models/Requests/VaultConnectionConsentUpdateResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |