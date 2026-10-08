# GetSalesOrderResponse

Sales Orders


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `StatusCode`                                        | *long*                                              | :heavy_check_mark:                                  | HTTP Response Status Code                           | 200                                                 |
| `Status`                                            | *string*                                            | :heavy_check_mark:                                  | HTTP Response Status                                | OK                                                  |
| `Service`                                           | *string*                                            | :heavy_check_mark:                                  | Apideck ID of service provider                      | acumatica                                           |
| `Resource`                                          | *string*                                            | :heavy_check_mark:                                  | Unified API resource name                           | SalesOrders                                         |
| `Operation`                                         | *string*                                            | :heavy_check_mark:                                  | Operation performed                                 | one                                                 |
| `Data`                                              | [SalesOrder](../../Models/Components/SalesOrder.md) | :heavy_check_mark:                                  | N/A                                                 |                                                     |
| `Meta`                                              | [Meta](../../Models/Components/Meta.md)             | :heavy_minus_sign:                                  | Response metadata                                   |                                                     |