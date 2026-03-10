# BillingMethod

Method used for billing this project

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BillingMethod.FixedPrice;

// Open enum: use .Of() to create instances from custom string values
var custom = BillingMethod.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `FixedPrice`       | fixed_price        |
| `TimeAndMaterials` | time_and_materials |
| `MilestoneBased`   | milestone_based    |
| `Retainer`         | retainer           |
| `NonBillable`      | non_billable       |