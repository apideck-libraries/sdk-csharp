# ProjectType

Type or category of the project

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ProjectType.ClientProject;

// Open enum: use .Of() to create instances from custom string values
var custom = ProjectType.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `ClientProject`       | client_project        |
| `InternalProject`     | internal_project      |
| `Maintenance`         | maintenance           |
| `ResearchDevelopment` | research_development  |
| `Training`            | training              |
| `Other`               | other                 |