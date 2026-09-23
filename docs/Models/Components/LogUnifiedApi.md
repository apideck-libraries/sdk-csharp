# LogUnifiedApi

Which Unified Api request was made to.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = LogUnifiedApi.Crm;

// Open enum: use .Of() to create instances from custom string values
var custom = LogUnifiedApi.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Crm`           | crm             |
| `Lead`          | lead            |
| `Proxy`         | proxy           |
| `Vault`         | vault           |
| `Accounting`    | accounting      |
| `Hris`          | hris            |
| `Ats`           | ats             |
| `Ecommerce`     | ecommerce       |
| `IssueTracking` | issue-tracking  |
| `Pos`           | pos             |
| `FileStorage`   | file-storage    |
| `Sms`           | sms             |