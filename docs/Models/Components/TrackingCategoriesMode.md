# TrackingCategoriesMode

The mode of tracking categories for the company on transactions

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = TrackingCategoriesMode.Transaction;

// Open enum: use .Of() to create instances from custom string values
var custom = TrackingCategoriesMode.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Transaction` | transaction   |
| `Line`        | line          |
| `Both`        | both          |
| `Disabled`    | disabled      |