# RequestRate

The rate at which requests for resources will be made to downstream.


## Fields

| Field                                   | Type                                    | Required                                | Description                             |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `Rate`                                  | *long*                                  | :heavy_check_mark:                      | The number of requests per window unit. |
| `Size`                                  | *long*                                  | :heavy_check_mark:                      | Size of request window.                 |
| `Unit`                                  | [Unit](../../Models/Components/Unit.md) | :heavy_check_mark:                      | The window unit for the rate.           |