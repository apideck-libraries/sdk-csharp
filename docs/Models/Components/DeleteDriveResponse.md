# DeleteDriveResponse

Drives


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `StatusCode`                                      | *long*                                            | :heavy_check_mark:                                | HTTP Response Status Code                         | 200                                               |
| `Status`                                          | *string*                                          | :heavy_check_mark:                                | HTTP Response Status                              | OK                                                |
| `Service`                                         | *string*                                          | :heavy_check_mark:                                | Apideck ID of service provider                    | google-drive                                      |
| `Resource`                                        | *string*                                          | :heavy_check_mark:                                | Unified API resource name                         | Drives                                            |
| `Operation`                                       | *string*                                          | :heavy_check_mark:                                | Operation performed                               | delete                                            |
| `Data`                                            | [UnifiedId](../../Models/Components/UnifiedId.md) | :heavy_check_mark:                                | N/A                                               |                                                   |