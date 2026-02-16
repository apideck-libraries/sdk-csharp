# ProxyDeleteProxyResponse


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `HttpMeta`                                              | [HTTPMetadata](../../Models/Components/HTTPMetadata.md) | :heavy_check_mark:                                      | N/A                                                     |
| `ResponseJson`                                          | Dictionary<String, *object*>                            | :heavy_minus_sign:                                      | Ok                                                      |
| `ResponseBinary`                                        | *byte[]*                                                | :heavy_minus_sign:                                      | Ok                                                      |
| `ResponsePdf`                                           | *byte[]*                                                | :heavy_minus_sign:                                      | Ok                                                      |
| `ResponseXml`                                           | *string*                                                | :heavy_minus_sign:                                      | Ok                                                      |
| `ResponseCsv`                                           | *string*                                                | :heavy_minus_sign:                                      | Ok                                                      |
| `ResponseText`                                          | *string*                                                | :heavy_minus_sign:                                      | Ok                                                      |
| `ErrorJson`                                             | Dictionary<String, *object*>                            | :heavy_minus_sign:                                      | Proxy error                                             |
| `ErrorXml`                                              | *string*                                                | :heavy_minus_sign:                                      | Proxy error                                             |
| `ErrorHtml`                                             | *string*                                                | :heavy_minus_sign:                                      | Proxy error                                             |
| `ErrorText`                                             | *string*                                                | :heavy_minus_sign:                                      | Proxy error                                             |
| `Headers`                                               | Dictionary<String, List<*string*>>                      | :heavy_check_mark:                                      | N/A                                                     |