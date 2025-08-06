# EmployeeSchedules
(*Hris.EmployeeSchedules*)

## Overview

### Available Operations

* [List](#list) - List Employee Schedules

## List

List schedules for employee, a schedule is a work pattern, not the actual worked hours, for an employee.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="hris.employeeSchedulesAll" method="get" path="/hris/schedules/employees/{employee_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

HrisEmployeeSchedulesAllRequest req = new HrisEmployeeSchedulesAllRequest() {
    EmployeeId = "<id>",
    ServiceId = "salesforce",
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Hris.EmployeeSchedules.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [HrisEmployeeSchedulesAllRequest](../../Models/Requests/HrisEmployeeSchedulesAllRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[HrisEmployeeSchedulesAllResponse](../../Models/Requests/HrisEmployeeSchedulesAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |