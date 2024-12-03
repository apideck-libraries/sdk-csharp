# BalanceSheetLiabilitiesAccount

A balance sheet liabilities account represents the financial position of a company at a specific point in time.


## Fields

| Field                                  | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `AccountId`                            | *string*                               | :heavy_minus_sign:                     | The unique identifier for the account. | 123456                                 |
| `Code`                                 | *string*                               | :heavy_minus_sign:                     | The account code of the account        | 1100                                   |
| `Name`                                 | *string*                               | :heavy_minus_sign:                     | The name of the account.               | Current assets                         |
| `Value`                                | *double*                               | :heavy_minus_sign:                     | The amount or value of the item        | 1000                                   |
| `Items`                                | *object*                               | :heavy_minus_sign:                     | A list of balance sheet accounts       |                                        |