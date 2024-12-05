# SchemaSupport

When a connector has schema_support, a call can be made to retrieve a json schema that describes a downstream resource.


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            | Example                                                |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Supported`                                            | *bool*                                                 | :heavy_minus_sign:                                     | Can a resource schema be retrieved for this connector? | true                                                   |