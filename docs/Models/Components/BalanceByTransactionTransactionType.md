# BalanceByTransactionTransactionType

Type of the transaction.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = BalanceByTransactionTransactionType.Invoice;

// Open enum: use .Of() to create instances from custom string values
var custom = BalanceByTransactionTransactionType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Invoice`     | invoice       |
| `CreditNote`  | credit_note   |
| `Bill`        | bill          |
| `Payment`     | payment       |
| `BillPayment` | bill_payment  |