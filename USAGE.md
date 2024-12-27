<!-- Start SDK Example Usage [usage] -->
```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

AccountingTaxRatesAllRequest req = new AccountingTaxRatesAllRequest() {
    ServiceId = "salesforce",
    Filter = new TaxRatesFilter() {
        Assets = true,
        Equity = true,
        Expenses = true,
        Liabilities = true,
        Revenue = true,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

AccountingTaxRatesAllResponse? res = await sdk.Accounting.TaxRates.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```
<!-- End SDK Example Usage [usage] -->