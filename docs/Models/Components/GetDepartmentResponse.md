# GetDepartmentResponse

Departments


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `StatusCode`                                        | *long*                                              | :heavy_check_mark:                                  | HTTP Response Status Code                           | 200                                                 |
| `Status`                                            | *string*                                            | :heavy_check_mark:                                  | HTTP Response Status                                | OK                                                  |
| `Service`                                           | *string*                                            | :heavy_check_mark:                                  | Apideck ID of service provider                      | workday                                             |
| `Resource`                                          | *string*                                            | :heavy_check_mark:                                  | Unified API resource name                           | Departments                                         |
| `Operation`                                         | *string*                                            | :heavy_check_mark:                                  | Operation performed                                 | one                                                 |
| `Data`                                              | [Department](../../Models/Components/Department.md) | :heavy_check_mark:                                  | N/A                                                 |                                                     |