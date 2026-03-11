# ConnectorAuthType

Type of authorization used by the connector

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ConnectorAuthType.Oauth2;

// Open enum: use .Of() to create instances from custom string values
var custom = ConnectorAuthType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Oauth2` | oauth2   |
| `ApiKey` | apiKey   |
| `Basic`  | basic    |
| `Custom` | custom   |
| `None`   | none     |