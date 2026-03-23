# LinkedFinancialAccountAccountType

The type of account being referenced. Use `ledger_account` for GL accounts from the chart of accounts, or `bank_account` for bank account entities. When not specified, the connector will use its default behavior.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LinkedFinancialAccountAccountType.LedgerAccount;

// Open enum: use .Of() to create instances from custom string values
var custom = LinkedFinancialAccountAccountType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `LedgerAccount` | ledger_account  |
| `BankAccount`   | bank_account    |
| `Employee`      | employee        |