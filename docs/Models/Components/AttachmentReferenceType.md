# AttachmentReferenceType

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = AttachmentReferenceType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = AttachmentReferenceType.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Invoice` | invoice   |
| `Bill`    | bill      |
| `Expense` | expense   |
| `Quote`   | quote     |