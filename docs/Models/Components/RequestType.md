# RequestType

The type of request

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = RequestType.Vacation;

// Open enum: use .Of() to create instances from custom string values
var custom = RequestType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Vacation`    | vacation      |
| `Sick`        | sick          |
| `Personal`    | personal      |
| `JuryDuty`    | jury_duty     |
| `Volunteer`   | volunteer     |
| `Bereavement` | bereavement   |
| `Other`       | other         |