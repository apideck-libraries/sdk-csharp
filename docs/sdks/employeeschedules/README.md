# EmployeeSchedules
(*Hris.EmployeeSchedules*)

## Overview

### Available Operations

* [List](#list) - List Employee Schedules

## List

List schedules for employee, a schedule is a work pattern, not the actual worked hours, for an employee.

### Example Usage

```csharp
using ApiDeckSdk;
using ApiDeckSdk.Models.Requests;
using System.Collections.Generic;
using ApiDeckSdk.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
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

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| ApiDeckSdk.Models.Errors.BadRequestResponse      | 400                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnauthorizedResponse    | 401                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.PaymentRequiredResponse | 402                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.NotFoundResponse        | 404                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.UnprocessableResponse   | 422                                              | application/json                                 |
| ApiDeckSdk.Models.Errors.APIException            | 4XX, 5XX                                         | \*/\*                                            |