# GetActivityResponse

Activity


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     | Example                                         |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `StatusCode`                                    | *long*                                          | :heavy_check_mark:                              | HTTP Response Status Code                       | 200                                             |
| `Status`                                        | *string*                                        | :heavy_check_mark:                              | HTTP Response Status                            | OK                                              |
| `Service`                                       | *string*                                        | :heavy_check_mark:                              | Apideck ID of service provider                  | zoho-crm                                        |
| `Resource`                                      | *string*                                        | :heavy_check_mark:                              | Unified API resource name                       | activities                                      |
| `Operation`                                     | *string*                                        | :heavy_check_mark:                              | Operation performed                             | one                                             |
| `Data`                                          | [Activity](../../Models/Components/Activity.md) | :heavy_check_mark:                              | N/A                                             |                                                 |