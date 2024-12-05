# Payments
(*Accounting.Payments*)

## Overview

### Available Operations

* [List](#list) - List Payments
* [Create](#create) - Create Payment
* [Get](#get) - Get Payment
* [Update](#update) - Update Payment
* [Delete](#delete) - Delete Payment

## List

List Payments

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingPaymentsAllRequest req = new AccountingPaymentsAllRequest() {
    ServiceId = "salesforce",
    Filter = new PaymentsFilter() {
        UpdatedSince = System.DateTime.Parse("2020-09-30T07:43:32.000Z"),
    },
    Sort = new PaymentsSort() {
        By = Apideck.Unify.SDK.Models.Components.PaymentsSortBy.UpdatedAt,
        Direction = Apideck.Unify.SDK.Models.Components.SortDirection.Desc,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Payments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingPaymentsAllRequest](../../Models/Requests/AccountingPaymentsAllRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingPaymentsAllResponse](../../Models/Requests/AccountingPaymentsAllResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.BadRequestResponse      | 400                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnprocessableResponse   | 422                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |

## Create

Create Payment

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingPaymentsAddRequest req = new AccountingPaymentsAddRequest() {
    Payment = new PaymentInput() {
        Currency = Apideck.Unify.SDK.Models.Components.Currency.Usd,
        CurrencyRate = 0.69D,
        TotalAmount = 49.99D,
        Reference = "123456",
        PaymentMethod = "cash",
        PaymentMethodReference = "123456",
        PaymentMethodId = "12345",
        Account = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        CompanyId = "12345",
        Reconciled = true,
        Status = Apideck.Unify.SDK.Models.Components.PaymentStatus.Authorised,
        Type = Apideck.Unify.SDK.Models.Components.PaymentType.AccountsReceivable,
        Allocations = new List<AllocationInput>() {
            new AllocationInput() {
                Id = "123456",
                Amount = 49.99D,
                AllocationId = "123456",
            },
        },
        Note = "Some notes about this transaction",
        Number = "123456",
        TrackingCategories = new List<LinkedTrackingCategory>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateBoolean(
                    true
                ),
            },
        },
        RowVersion = "1-12345",
        DisplayId = "123456",
        PassThrough = new List<PassThroughBody>() {
            new PassThroughBody() {
                ServiceId = "<id>",
                ExtendPaths = new List<ExtendPaths>() {
                    new ExtendPaths() {
                        Path = "$.nested.property",
                        Value = new Dictionary<string, object>() {
                            { "TaxClassificationRef", new Dictionary<string, object>() {
                                { "value", "EUC-99990201-V1-00020000" },
                            } },
                        },
                    },
                },
            },
        },
    },
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Payments.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingPaymentsAddRequest](../../Models/Requests/AccountingPaymentsAddRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingPaymentsAddResponse](../../Models/Requests/AccountingPaymentsAddResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.BadRequestResponse      | 400                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnprocessableResponse   | 422                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |

## Get

Get Payment

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingPaymentsOneRequest req = new AccountingPaymentsOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
};

var res = await sdk.Accounting.Payments.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AccountingPaymentsOneRequest](../../Models/Requests/AccountingPaymentsOneRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AccountingPaymentsOneResponse](../../Models/Requests/AccountingPaymentsOneResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.BadRequestResponse      | 400                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnprocessableResponse   | 422                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |

## Update

Update Payment

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingPaymentsUpdateRequest req = new AccountingPaymentsUpdateRequest() {
    Id = "<id>",
    Payment = new PaymentInput() {
        Currency = Apideck.Unify.SDK.Models.Components.Currency.Usd,
        CurrencyRate = 0.69D,
        TotalAmount = 49.99D,
        Reference = "123456",
        PaymentMethod = "cash",
        PaymentMethodReference = "123456",
        PaymentMethodId = "12345",
        Account = new LinkedLedgerAccountInput() {
            Id = "123456",
            NominalCode = "N091",
            Code = "453",
        },
        TransactionDate = System.DateTime.Parse("2021-05-01T12:00:00.000Z"),
        Customer = new LinkedCustomerInput() {
            Id = "12345",
            DisplayName = "Windsurf Shop",
            Email = "boring@boring.com",
        },
        CompanyId = "12345",
        Reconciled = true,
        Status = Apideck.Unify.SDK.Models.Components.PaymentStatus.Authorised,
        Type = Apideck.Unify.SDK.Models.Components.PaymentType.AccountsReceivable,
        Allocations = new List<AllocationInput>() {
            new AllocationInput() {
                Id = "123456",
                Amount = 49.99D,
                AllocationId = "123456",
            },
        },
        Note = "Some notes about this transaction",
        Number = "123456",
        TrackingCategories = new List<LinkedTrackingCategory>() {
            new LinkedTrackingCategory() {
                Id = "123456",
                Name = "New York",
            },
        },
        CustomFields = new List<CustomField>() {
            new CustomField() {
                Id = "2389328923893298",
                Name = "employee_level",
                Description = "Employee Level",
                Value = Value.CreateArrayOf6(
                    new List<Six>() {
                        new Six() {},
                    }
                ),
            },
        },
        RowVersion = "1-12345",
        DisplayId = "123456",
        PassThrough = new List<PassThroughBody>() {
            new PassThroughBody() {
                ServiceId = "<id>",
                ExtendPaths = new List<ExtendPaths>() {
                    new ExtendPaths() {
                        Path = "$.nested.property",
                        Value = new Dictionary<string, object>() {
                            { "TaxClassificationRef", new Dictionary<string, object>() {
                                { "value", "EUC-99990201-V1-00020000" },
                            } },
                        },
                    },
                },
            },
        },
    },
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Payments.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingPaymentsUpdateRequest](../../Models/Requests/AccountingPaymentsUpdateRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingPaymentsUpdateResponse](../../Models/Requests/AccountingPaymentsUpdateResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.BadRequestResponse      | 400                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnprocessableResponse   | 422                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |

## Delete

Delete Payment

### Example Usage

```csharp
using Apideck.Unify.SDK;
using Apideck.Unify.SDK.Models.Requests;
using Apideck.Unify.SDK.Models.Components;

var sdk = new Apideck(
    apiKey: "<YOUR_API_KEY_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingPaymentsDeleteRequest req = new AccountingPaymentsDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Accounting.Payments.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AccountingPaymentsDeleteRequest](../../Models/Requests/AccountingPaymentsDeleteRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AccountingPaymentsDeleteResponse](../../Models/Requests/AccountingPaymentsDeleteResponse.md)**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| Apideck.Unify.SDK.Models.Errors.BadRequestResponse      | 400                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnauthorizedResponse    | 401                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.PaymentRequiredResponse | 402                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.NotFoundResponse        | 404                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.UnprocessableResponse   | 422                                                     | application/json                                        |
| Apideck.Unify.SDK.Models.Errors.APIException            | 4XX, 5XX                                                | \*/\*                                                   |