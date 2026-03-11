# ApplicantGender

The gender represents the gender identity of a person.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ApplicantGender.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = ApplicantGender.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Male`         | male           |
| `Female`       | female         |
| `Unisex`       | unisex         |
| `Other`        | other          |
| `NotSpecified` | not_specified  |