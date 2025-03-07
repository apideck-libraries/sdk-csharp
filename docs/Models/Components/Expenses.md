# Expenses

The operating expenses accounts


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Id`                                                              | *string*                                                          | :heavy_minus_sign:                                                | A unique identifier for an object.                                | 12345                                                             |
| `Code`                                                            | *string*                                                          | :heavy_minus_sign:                                                | The account code of the account                                   | 1100                                                              |
| `Title`                                                           | *string*                                                          | :heavy_minus_sign:                                                | The name of the account.                                          | Current assets                                                    |
| `Type`                                                            | [ProfitAndLossType](../../Models/Components/ProfitAndLossType.md) | :heavy_minus_sign:                                                | The type of profit and loss                                       | Section                                                           |
| `Total`                                                           | *double*                                                          | :heavy_check_mark:                                                | The total amount of the transaction                               | 49.99                                                             |
| `Records`                                                         | *object*                                                          | :heavy_check_mark:                                                | N/A                                                               |                                                                   |