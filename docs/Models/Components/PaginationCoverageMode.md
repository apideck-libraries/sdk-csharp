# PaginationCoverageMode

How pagination is implemented on this connector. Native mode means Apideck is using the pagination parameters of the connector. With virtual pagination, the connector does not support pagination, but Apideck emulates it.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = PaginationCoverageMode.Native;

// Open enum: use .Of() to create instances from custom string values
var custom = PaginationCoverageMode.Of("custom_value");
```


## Values

| Name      | Value     |
| --------- | --------- |
| `Native`  | native    |
| `Virtual` | virtual   |