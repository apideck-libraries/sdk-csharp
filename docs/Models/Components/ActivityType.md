# ActivityType

The type of the activity

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = ActivityType.Call;

// Open enum: use .Of() to create instances from custom string values
var custom = ActivityType.Of("custom_value");
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Call`       | call         |
| `Meeting`    | meeting      |
| `Email`      | email        |
| `Note`       | note         |
| `Task`       | task         |
| `Deadline`   | deadline     |
| `SendLetter` | send-letter  |
| `SendQuote`  | send-quote   |
| `Other`      | other        |