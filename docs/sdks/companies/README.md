# Accounting.Companies

## Overview

### Available Operations

* [List](#list) - List companies

## List

List all companies accessible through the current connection. Only connectors that support multi-company access (x-apideck-supports-multi-company) will return a list of companies. Use the returned company ID in the x-apideck-company-id header to scope subsequent requests to a specific company.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="accounting.companiesAll" method="get" path="/accounting/companies" -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX",
    apiKey: "<YOUR_BEARER_TOKEN_HERE>"
);

AccountingCompaniesAllRequest req = new AccountingCompaniesAllRequest() {
    ServiceId = "salesforce",
    CompanyId = "12345",
    Fields = "id,updated_at",
};

AccountingCompaniesAllResponse? res = await sdk.Accounting.Companies.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AccountingCompaniesAllRequest](../../Models/Requests/AccountingCompaniesAllRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AccountingCompaniesAllResponse](../../Models/Requests/AccountingCompaniesAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |