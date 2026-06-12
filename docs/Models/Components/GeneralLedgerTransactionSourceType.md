# GeneralLedgerTransactionSourceType

The originating transaction type that produced this posting in the general ledger. Discriminates whether the entry came from an invoice, a bill, a payment, a manual journal, etc. This is the key field that distinguishes general-ledger-transactions from journal-entries (which only covers manually-captured entries). May be `null` when the upstream connector did not return an origin discriminator (e.g. Xero's single-record endpoint strips `SourceType` for every record; certain historical records also omit it). To recover a populated value, query the list endpoint.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = GeneralLedgerTransactionSourceType.Other;

// Open enum: use .Of() to create instances from custom string values
var custom = GeneralLedgerTransactionSourceType.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Other`        | other          |
| `Invoice`      | invoice        |
| `Bill`         | bill           |
| `CreditNote`   | credit_note    |
| `Payment`      | payment        |
| `Refund`       | refund         |
| `Expense`      | expense        |
| `JournalEntry` | journal_entry  |
| `Payroll`      | payroll        |