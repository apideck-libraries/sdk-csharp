# ContactType

The type of the contact.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ContactType.Customer;

// Open enum: use .Of() to create instances from custom string values
var custom = ContactType.Of("custom_value");
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Customer` | customer   |
| `Supplier` | supplier   |
| `Employee` | employee   |
| `Personal` | personal   |