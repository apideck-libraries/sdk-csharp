# JobStatus

The status of the job.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = JobStatus.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = JobStatus.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Draft`               | draft                 |
| `Internal`            | internal              |
| `Published`           | published             |
| `Completed`           | completed             |
| `Placed`              | placed                |
| `OnHold`              | on-hold               |
| `Private`             | private               |
| `AcceptingCandidates` | accepting_candidates  |
| `Open`                | open                  |
| `Closed`              | closed                |
| `Archived`            | archived              |