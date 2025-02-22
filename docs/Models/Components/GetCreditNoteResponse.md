# GetCreditNoteResponse

Credit Note


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `StatusCode`                                        | *long*                                              | :heavy_check_mark:                                  | HTTP Response Status Code                           | 200                                                 |
| `Status`                                            | *string*                                            | :heavy_check_mark:                                  | HTTP Response Status                                | OK                                                  |
| `Service`                                           | *string*                                            | :heavy_check_mark:                                  | Apideck ID of service provider                      | xero                                                |
| `Resource`                                          | *string*                                            | :heavy_check_mark:                                  | Unified API resource name                           | credit-notes                                        |
| `Operation`                                         | *string*                                            | :heavy_check_mark:                                  | Operation performed                                 | one                                                 |
| `Data`                                              | [CreditNote](../../Models/Components/CreditNote.md) | :heavy_check_mark:                                  | N/A                                                 |                                                     |