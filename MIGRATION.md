
# Migration Guide

This guide helps you migrate from this SDK to new [Csharp SDK](https://github.com/apideck-libraries/sdk-csharp)

## Key changes

1. **Installation**

```sh
# Old package
dotnet add package Apideck

# New package
dotnet add package ApideckUnifySdk
```

2. **SDK Initialization**


```csharp
// Old SDK
Configuration config = new Configuration();
config.AddApiKey("Authorization", "API_KEY");
config.AddApiKeyPrefix("Authorization", "Bearer");
var apiInstance = new CrmApi(config);

// New SDK
var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);
```

3. **Method Naming Changes**

```csharp
// Old SDK
var result = apiInstance.CompaniesAll(raw, consumerId, appId, serviceId);

// New SDK
var req = new AccountingCompaniesListRequest() {
    ServiceId = "salesforce"
};
var result = await sdk.Accounting.Companies.ListAsync(req);
```


4. **Request/Response Structure**

```csharp
// Old SDK
var result = apiInstance.CompaniesAll();
foreach (var company in result.Data) {
    Console.WriteLine(company.Name);
}

// New SDK
var req = new AccountingCompaniesListRequest() {
    ServiceId = "salesforce",
    Filter = new CompaniesFilter() {
        // Add filters here
    }
};
var result = await sdk.Accounting.Companies.ListAsync(req);

```

Every response includes httpMeta which provides access to the raw HTTP request and response:
The `httpMeta` object is essential because it provides detailed information about the HTTP request and response, which can be crucial for debugging and logging purposes.



5. **Method Naming Convention Changes**

The new SDK uses a more consistent and intuitive naming convention. Here's how the old methods map to new ones:

| Old Method | New Method |
|------------|------------|
| CompaniesAll | Companies.ListAsync |
| CompaniesAdd | Companies.CreateAsync |
| CompaniesOne | Companies.GetAsync |
| CompaniesUpdate | Companies.UpdateAsync |
...

6. **Async/await support for all API calls**

The new SDK fully supports async/await patterns by default.

```csharp
// Old SDK - synchronous
var result = apiInstance.CompaniesAll();

// New SDK - async/await
var result = await sdk.Accounting.Companies.ListAsync(req);
```

The previous SDK had a [known issue](https://github.com/apideck-libraries/dotnet-sdk?tab=readme-ov-file#async-functionality-with-applied-filters) where filters didn't work correctly with async operations. This has been completely resolved in the new SDK.


7. **Error handling**

```csharp
// Old SDK
try {
    var result = apiInstance.CompaniesAll(raw, consumerId, appId, serviceId);
}
catch (ApiException e) {
    Console.WriteLine("Exception when calling API: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine("Detail: " + e.ErrorContent);
}

// New SDK
try {
    var result = await sdk.Accounting.Companies.ListAsync(req);
}
catch (Exception ex) {
    if (ex is BadRequestResponse badRequest) {
        // Handle 400 error
    }
    else if (ex is UnauthorizedResponse unauthorized) {
        // Handle 401 error
    }
    else if (ex is ApideckUnifySdk.Models.Errors.APIException apiError) {
        // Handle other API errors
    }
}
```

For more information about error handling, please check our [documentation](https://github.com/apideck-libraries/sdk-csharp/tree/main?tab=readme-ov-file#error-handling)



## Summary of breaking Changes

1. Package name has changed from Apideck to ApideckUnifySdk
2. All API methods now follow a consistent naming pattern and are async by default
3. SDK initialization has been simplified with a unified configuration object
4. More specific error types for better error handling
5. Request/response models have been updated for better type safety
6. All operations now use dedicated request objects for parameters


## Need help?

If you encounter any issues during migration:

1. Checkout out our [documentation](https://github.com/apideck-libraries/sdk-csharp/tree/main?tab=readme-ov-file#apideckunifysdk)
2. Open an issue on our [GitHub repository](https://github.com/apideck-libraries/sdk-csharp/issues)
3. Contact our support at `support@apideck.com`