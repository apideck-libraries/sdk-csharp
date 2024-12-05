<!-- Start SDK Example Usage [usage] -->
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

var res = await sdk.Accounting.TaxRates.ListAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->