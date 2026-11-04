# ProjectUpdateInputProjectStatus

Current status of the project

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectUpdateInputProjectStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectUpdateInputProjectStatus.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Active`     | active       |
| `Completed`  | completed    |
| `OnHold`     | on_hold      |
| `Cancelled`  | cancelled    |
| `Draft`      | draft        |
| `InProgress` | in_progress  |
| `Approved`   | approved     |
| `Other`      | other        |