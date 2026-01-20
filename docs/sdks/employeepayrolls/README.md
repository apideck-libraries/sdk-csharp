# Hris.EmployeePayrolls

## Overview

### Available Operations

* [List](#list) - List Employee Payrolls
* [Get](#get) - Get Employee Payroll

## List

List payrolls for employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="hris.employeePayrollsAll" method="get" path="/hris/payrolls/employees/{employee_id}" -->
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

HrisEmployeePayrollsAllRequest req = new HrisEmployeePayrollsAllRequest() {
    EmployeeId = "<id>",
    ServiceId = "salesforce",
    Filter = new PayrollsFilter() {
        StartDate = "2022-04-08",
        EndDate = "2022-04-21",
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Hris.EmployeePayrolls.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisEmployeePayrollsAllRequest](../../Models/Requests/HrisEmployeePayrollsAllRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisEmployeePayrollsAllResponse](../../Models/Requests/HrisEmployeePayrollsAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Get

Get payroll for employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="hris.employeePayrollsOne" method="get" path="/hris/payrolls/employees/{employee_id}/payrolls/{payroll_id}" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

HrisEmployeePayrollsOneRequest req = new HrisEmployeePayrollsOneRequest() {
    PayrollId = "<id>",
    EmployeeId = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Hris.EmployeePayrolls.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisEmployeePayrollsOneRequest](../../Models/Requests/HrisEmployeePayrollsOneRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisEmployeePayrollsOneResponse](../../Models/Requests/HrisEmployeePayrollsOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |