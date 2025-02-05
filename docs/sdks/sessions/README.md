# Sessions
(*Vault.Sessions*)

## Overview

### Available Operations

* [Create](#create) - Create Session

## Create

Making a POST request to this endpoint will initiate a Hosted Vault session. Redirect the consumer to the returned
URL to allow temporary access to manage their integrations and settings.

Note: This is a short lived token that will expire after 1 hour (TTL: 3600).


### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

var res = await sdk.Vault.Sessions.CreateAsync(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    session: new Session() {
        ConsumerMetadata = new ConsumerMetadata() {
            AccountName = "SpaceX",
            UserName = "Elon Musk",
            Email = "elon@musk.com",
            Image = "https://www.spacex.com/static/images/share.jpg",
        },
        RedirectUri = "https://mysaas.com/dashboard",
        Settings = new SessionSettings() {
            UnifiedApis = new List<UnifiedApiId>() {
                UnifiedApiId.Crm,
            },
        },
        Theme = new Theme() {
            Favicon = "https://res.cloudinary.com/apideck/icons/intercom",
            Logo = "https://res.cloudinary.com/apideck/icons/intercom",
            PrimaryColor = "#286efa",
            SidepanelBackgroundColor = "#286efa",
            SidepanelTextColor = "#FFFFFF",
            VaultName = "Intercom",
            PrivacyUrl = "https://compliance.apideck.com/privacy-policy",
            TermsUrl = "https://www.termsfeed.com/terms-conditions/957c85c1b089ae9e3219c83eff65377e",
        },
        CustomConsumerSettings = new Dictionary<string, object>() {
            { "feature_flag_1", true },
            { "tax_rates", new List<object>() {
                new Dictionary<string, object>() {
                    { "id", "6" },
                    { "label", "6%" },
                },
                new Dictionary<string, object>() {
                    { "id", "21" },
                    { "label", "21%" },
                },
            } },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                  | Type                                                       | Required                                                   | Description                                                | Example                                                    |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `ConsumerId`                                               | *string*                                                   | :heavy_minus_sign:                                         | ID of the consumer which you want to get or push data from | test-consumer                                              |
| `AppId`                                                    | *string*                                                   | :heavy_minus_sign:                                         | The ID of your Unify application                           | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                    |
| `Session`                                                  | [Session](../../Models/Components/Session.md)              | :heavy_minus_sign:                                         | Additional redirect uri and/or consumer metadata           |                                                            |

### Response

**[VaultSessionsCreateResponse](../../Models/Requests/VaultSessionsCreateResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |