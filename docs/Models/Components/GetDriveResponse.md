# GetDriveResponse

Drives


## Fields

| Field                                     | Type                                      | Required                                  | Description                               | Example                                   |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `StatusCode`                              | *long*                                    | :heavy_check_mark:                        | HTTP Response Status Code                 | 200                                       |
| `Status`                                  | *string*                                  | :heavy_check_mark:                        | HTTP Response Status                      | OK                                        |
| `Service`                                 | *string*                                  | :heavy_check_mark:                        | Apideck ID of service provider            | google-drive                              |
| `Resource`                                | *string*                                  | :heavy_check_mark:                        | Unified API resource name                 | Drives                                    |
| `Operation`                               | *string*                                  | :heavy_check_mark:                        | Operation performed                       | one                                       |
| `Data`                                    | [Drive](../../Models/Components/Drive.md) | :heavy_check_mark:                        | N/A                                       |                                           |