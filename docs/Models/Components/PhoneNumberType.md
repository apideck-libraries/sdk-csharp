# PhoneNumberType

The type of phone number

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PhoneNumberType.Primary;

// Open enum: use .Of() to create instances from custom string values
var custom = PhoneNumberType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Primary`      | primary        |
| `Secondary`    | secondary      |
| `Home`         | home           |
| `Work`         | work           |
| `Office`       | office         |
| `Mobile`       | mobile         |
| `Assistant`    | assistant      |
| `Fax`          | fax            |
| `DirectDialIn` | direct-dial-in |
| `Personal`     | personal       |
| `Billing`      | billing        |
| `Other`        | other          |