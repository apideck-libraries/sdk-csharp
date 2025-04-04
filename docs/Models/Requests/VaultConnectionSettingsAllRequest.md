# VaultConnectionSettingsAllRequest


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                | Example                                                    |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `ConsumerId`                                               | *string*                                                   | :heavy_minus_sign:                                         | ID of the consumer which you want to get or push data from | test-consumer                                              |
| `AppId`                                                    | *string*                                                   | :heavy_minus_sign:                                         | The ID of your Unify application                           | dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX                    |
| `UnifiedApi`                                               | *string*                                                   | :heavy_check_mark:                                         | Unified API                                                | crm                                                        |
| `ServiceId`                                                | *string*                                                   | :heavy_check_mark:                                         | Service ID of the resource to return                       | pipedrive                                                  |
| `Resource`                                                 | *string*                                                   | :heavy_check_mark:                                         | Name of the resource (plural)                              | leads                                                      |