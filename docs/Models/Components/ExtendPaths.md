# ExtendPaths


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Path`                                                              | *string*                                                            | :heavy_check_mark:                                                  | JSONPath string specifying where to apply the value.                | $.nested.property                                                   |
| `Value`                                                             | *object*                                                            | :heavy_check_mark:                                                  | The value to set at the specified path, can be any type.            | {<br/>"TaxClassificationRef": {<br/>"value": "EUC-99990201-V1-00020000"<br/>}<br/>} |