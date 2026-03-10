# OAuthGrantType

OAuth grant type used by the connector. More info: https://oauth.net/2/grant-types

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = OAuthGrantType.AuthorizationCode;

// Open enum: use .Of() to create instances from custom string values
var custom = OAuthGrantType.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `AuthorizationCode` | authorization_code  |
| `ClientCredentials` | client_credentials  |
| `Password`          | password            |