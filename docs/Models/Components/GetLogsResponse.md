# GetLogsResponse

Logs


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `StatusCode`                                                | *long*                                                      | :heavy_check_mark:                                          | HTTP Response Status Code                                   | 200                                                         |
| `Status`                                                    | *string*                                                    | :heavy_check_mark:                                          | HTTP Response Status                                        | OK                                                          |
| `Data`                                                      | List<[Log](../../Models/Components/Log.md)>                 | :heavy_check_mark:                                          | N/A                                                         |                                                             |
| `Meta`                                                      | [Meta](../../Models/Components/Meta.md)                     | :heavy_minus_sign:                                          | Response metadata                                           |                                                             |
| `Links`                                                     | [Links](../../Models/Components/Links.md)                   | :heavy_minus_sign:                                          | Links to navigate to previous or next pages through the API |                                                             |