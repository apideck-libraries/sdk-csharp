# GetEmployeesResponse

Employees


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `StatusCode`                                                | *long*                                                      | :heavy_check_mark:                                          | HTTP Response Status Code                                   | 200                                                         |
| `Status`                                                    | *string*                                                    | :heavy_check_mark:                                          | HTTP Response Status                                        | OK                                                          |
| `Service`                                                   | *string*                                                    | :heavy_check_mark:                                          | Apideck ID of service provider                              | sage-hr                                                     |
| `Resource`                                                  | *string*                                                    | :heavy_check_mark:                                          | Unified API resource name                                   | Employees                                                   |
| `Operation`                                                 | *string*                                                    | :heavy_check_mark:                                          | Operation performed                                         | all                                                         |
| `Data`                                                      | List<[Employee](../../Models/Components/Employee.md)>       | :heavy_check_mark:                                          | N/A                                                         |                                                             |
| `Meta`                                                      | [Meta](../../Models/Components/Meta.md)                     | :heavy_minus_sign:                                          | Response metadata                                           |                                                             |
| `Links`                                                     | [Links](../../Models/Components/Links.md)                   | :heavy_minus_sign:                                          | Links to navigate to previous or next pages through the API |                                                             |