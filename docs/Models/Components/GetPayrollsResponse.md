# GetPayrollsResponse

Payrolls


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `StatusCode`                                        | *long*                                              | :heavy_check_mark:                                  | HTTP Response Status Code                           | 200                                                 |
| `Status`                                            | *string*                                            | :heavy_check_mark:                                  | HTTP Response Status                                | OK                                                  |
| `Service`                                           | *string*                                            | :heavy_check_mark:                                  | Apideck ID of service provider                      | sage-hr                                             |
| `Resource`                                          | *string*                                            | :heavy_check_mark:                                  | Unified API resource name                           | Employees                                           |
| `Operation`                                         | *string*                                            | :heavy_check_mark:                                  | Operation performed                                 | all                                                 |
| `Data`                                              | List<[Payroll](../../Models/Components/Payroll.md)> | :heavy_check_mark:                                  | N/A                                                 |                                                     |