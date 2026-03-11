# JournalEntryLineItemType

Debit entries are considered positive, and credit entries are considered negative.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = JournalEntryLineItemType.Debit;

// Open enum: use .Of() to create instances from custom string values
var custom = JournalEntryLineItemType.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Debit`  | debit    |
| `Credit` | credit   |