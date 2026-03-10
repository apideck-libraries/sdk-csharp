# OauthCredentialsSource

Location of the OAuth client credentials. For most connectors the OAuth client credentials are stored on integration and managed by the application owner. For others they are stored on connection and managed by the consumer in Vault.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = OauthCredentialsSource.Integration;

// Open enum: use .Of() to create instances from custom string values
var custom = OauthCredentialsSource.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Integration` | integration   |
| `Connection`  | connection    |