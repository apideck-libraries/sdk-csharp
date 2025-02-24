# GetCustomFieldsResponse

Custom mapping


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `StatusCode`                                                            | *long*                                                                  | :heavy_check_mark:                                                      | HTTP Response Status Code                                               | 200                                                                     |
| `Status`                                                                | *string*                                                                | :heavy_check_mark:                                                      | HTTP Response Status                                                    | OK                                                                      |
| `Data`                                                                  | List<[CustomFieldFinder](../../Models/Components/CustomFieldFinder.md)> | :heavy_check_mark:                                                      | N/A                                                                     |                                                                         |
| `Raw`                                                                   | Dictionary<String, *object*>                                            | :heavy_minus_sign:                                                      | Raw response from the integration when raw=true query param is provided |                                                                         |