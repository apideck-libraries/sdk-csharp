# Employees
(*Hris.Employees*)

## Overview

### Available Operations

* [List](#list) - List Employees
* [Create](#create) - Create Employee
* [Get](#get) - Get Employee
* [Update](#update) - Update Employee
* [Delete](#delete) - Delete Employee

## List

Apideck operates as a stateless Unified API, which means that the list endpoint only provides a portion of the employee model. This is due to the fact that most HRIS systems do not readily provide all data in every call. However, you can access the complete employee model through an employee detail call.

### Example Usage

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

HrisEmployeesAllRequest req = new HrisEmployeesAllRequest() {
    ServiceId = "salesforce",
    Filter = new EmployeesFilter() {
        CompanyId = "1234",
        Email = "elon@tesla.com",
        FirstName = "Elon",
        Title = "Manager",
        LastName = "Musk",
        ManagerId = "1234",
        EmploymentStatus = EmployeesFilterEmploymentStatus.Active,
        EmployeeNumber = "123456-AB",
        DepartmentId = "1234",
    },
    Sort = new EmployeesSort() {
        By = EmployeesSortBy.CreatedAt,
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
    Fields = "id,updated_at",
};

HrisEmployeesAllResponse? res = await sdk.Hris.Employees.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisEmployeesAllRequest](../../Models/Requests/HrisEmployeesAllRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisEmployeesAllResponse](../../Models/Requests/HrisEmployeesAllResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Create

Create Employee

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisEmployeesAddRequest req = new HrisEmployeesAddRequest() {
    Employee = new EmployeeInput() {
        Id = "12345",
        FirstName = "Elon",
        LastName = "Musk",
        MiddleName = "D.",
        DisplayName = "Technoking",
        PreferredName = "Elon Musk",
        Initials = "EM",
        Salutation = "Mr",
        Title = "CEO",
        MaritalStatus = "married",
        Partner = new PersonInput() {
            FirstName = "Elon",
            LastName = "Musk",
            MiddleName = "D.",
            Gender = Gender.Male,
            Initials = "EM",
            Birthday = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
            DeceasedOn = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
        },
        Division = "Europe",
        DivisionId = "12345",
        DepartmentId = "12345",
        DepartmentName = "12345",
        Team = new Team() {
            Id = "1234",
            Name = "Full Stack Engineers",
        },
        CompanyId = "23456",
        CompanyName = "SpaceX",
        EmploymentStartDate = "2021-10-26",
        EmploymentEndDate = "2028-10-26",
        LeavingReason = LeavingReason.Resigned,
        EmployeeNumber = "123456-AB",
        EmploymentStatus = EmploymentStatus.Active,
        Ethnicity = "African American",
        Manager = new Manager() {
            Id = "12345",
            Name = "Elon Musk",
            FirstName = "Elon",
            LastName = "Musk",
            Email = "elon@musk.com",
            EmploymentStatus = EmploymentStatus.Active,
        },
        DirectReports = new List<string>() {
            "a0d636c6-43b3-4bde-8c70-85b707d992f4",
            "a98lfd96-43b3-4bde-8c70-85b707d992e6",
        },
        SocialSecurityNumber = "123456789",
        Birthday = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
        DeceasedOn = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
        CountryOfBirth = "US",
        Description = "A description",
        Gender = Gender.Male,
        Pronouns = "she,her",
        PreferredLanguage = "EN",
        Languages = new List<string>() {
            "EN",
        },
        Nationalities = new List<string>() {
            "US",
        },
        PhotoUrl = "https://unavatar.io/elon-musk",
        Timezone = "Europe/London",
        Source = "lever",
        SourceId = "12345",
        RecordUrl = "https://app.intercom.io/contacts/12345",
        Jobs = new List<EmployeeJobInput>() {
            new EmployeeJobInput() {
                Title = "CEO",
                Role = "Sales",
                StartDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-08-12")),
                EndDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-08-12")),
                CompensationRate = 72000D,
                Currency = Currency.Usd,
                PaymentUnit = PaymentUnit.Year,
                HiredAt = LocalDate.FromDateTime(System.DateTime.Parse("2020-08-12")),
                IsPrimary = true,
                IsManager = true,
                Status = EmployeeJobStatus.Active,
                Location = new Address() {
                    Id = "123",
                    Type = ApideckUnifySdk.Models.Components.Type.Primary,
                    String = "25 Spring Street, Blackburn, VIC 3130",
                    Name = "HQ US",
                    Line1 = "Main street",
                    Line2 = "apt #",
                    Line3 = "Suite #",
                    Line4 = "delivery instructions",
                    StreetNumber = "25",
                    City = "San Francisco",
                    State = "CA",
                    PostalCode = "94104",
                    Country = "US",
                    Latitude = "40.759211",
                    Longitude = "-73.984638",
                    County = "Santa Clara",
                    ContactName = "Elon Musk",
                    Salutation = "Mr",
                    PhoneNumber = "111-111-1111",
                    Fax = "122-111-1111",
                    Email = "elon@musk.com",
                    Website = "https://elonmusk.com",
                    Notes = "Address notes or delivery instructions.",
                    RowVersion = "1-12345",
                },
            },
        },
        Compensations = new List<EmployeeCompensationInput>() {
            new EmployeeCompensationInput() {
                Rate = 50D,
                PaymentUnit = PaymentUnit.Hour,
                FlsaStatus = FlsaStatus.Nonexempt,
                EffectiveDate = "2021-06-11",
            },
        },
        WorksRemote = true,
        Addresses = new List<Address>() {
            new Address() {
                Id = "123",
                Type = ApideckUnifySdk.Models.Components.Type.Primary,
                String = "25 Spring Street, Blackburn, VIC 3130",
                Name = "HQ US",
                Line1 = "Main street",
                Line2 = "apt #",
                Line3 = "Suite #",
                Line4 = "delivery instructions",
                StreetNumber = "25",
                City = "San Francisco",
                State = "CA",
                PostalCode = "94104",
                Country = "US",
                Latitude = "40.759211",
                Longitude = "-73.984638",
                County = "Santa Clara",
                ContactName = "Elon Musk",
                Salutation = "Mr",
                PhoneNumber = "111-111-1111",
                Fax = "122-111-1111",
                Email = "elon@musk.com",
                Website = "https://elonmusk.com",
                Notes = "Address notes or delivery instructions.",
                RowVersion = "1-12345",
            },
        },
        PhoneNumbers = new List<PhoneNumber>() {
            new PhoneNumber() {
                Id = "12345",
                CountryCode = "1",
                AreaCode = "323",
                Number = "111-111-1111",
                Extension = "105",
                Type = PhoneNumberType.Primary,
            },
        },
        Emails = new List<Email>() {
            new Email() {
                Id = "123",
                Email = "elon@musk.com",
                Type = EmailType.Primary,
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
        SocialLinks = new List<SocialLink>() {
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
            },
        },
        BankAccounts = new List<BankAccount>() {
            new BankAccount() {
                BankName = "Monzo",
                AccountNumber = "123465",
                AccountName = "SPACEX LLC",
                AccountType = AccountType.CreditCard,
                Iban = "CH2989144532982975332",
                Bic = "AUDSCHGGXXX",
                RoutingNumber = "012345678",
                BsbNumber = "062-001",
                BranchIdentifier = "001",
                BankCode = "BNH",
                Currency = Currency.Usd,
            },
        },
        TaxCode = "1111",
        TaxId = "234-32-0000",
        DietaryPreference = "Veggie",
        FoodAllergies = new List<string>() {
            "No allergies",
        },
        ProbationPeriod = new ProbationPeriod() {
            StartDate = LocalDate.FromDateTime(System.DateTime.Parse("2021-10-01")),
            EndDate = LocalDate.FromDateTime(System.DateTime.Parse("2021-11-28")),
        },
        Tags = new List<string>() {
            "New",
        },
        RowVersion = "1-12345",
        Deleted = true,
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

var res = await sdk.Hris.Employees.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisEmployeesAddRequest](../../Models/Requests/HrisEmployeesAddRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisEmployeesAddResponse](../../Models/Requests/HrisEmployeesAddResponse.md)**

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

Get Employee

### Example Usage

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

HrisEmployeesOneRequest req = new HrisEmployeesOneRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
    Fields = "id,updated_at",
    Filter = new EmployeesOneFilter() {
        CompanyId = "1234",
    },
    PassThrough = new Dictionary<string, object>() {
        { "search", "San Francisco" },
    },
};

var res = await sdk.Hris.Employees.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisEmployeesOneRequest](../../Models/Requests/HrisEmployeesOneRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisEmployeesOneResponse](../../Models/Requests/HrisEmployeesOneResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Update

Update Employee

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;
using NodaTime;
using System.Collections.Generic;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisEmployeesUpdateRequest req = new HrisEmployeesUpdateRequest() {
    Id = "<id>",
    Employee = new EmployeeInput() {
        Id = "12345",
        FirstName = "Elon",
        LastName = "Musk",
        MiddleName = "D.",
        DisplayName = "Technoking",
        PreferredName = "Elon Musk",
        Initials = "EM",
        Salutation = "Mr",
        Title = "CEO",
        MaritalStatus = "married",
        Partner = new PersonInput() {
            FirstName = "Elon",
            LastName = "Musk",
            MiddleName = "D.",
            Gender = Gender.Male,
            Initials = "EM",
            Birthday = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
            DeceasedOn = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
        },
        Division = "Europe",
        DivisionId = "12345",
        DepartmentId = "12345",
        DepartmentName = "12345",
        Team = new Team() {
            Id = "1234",
            Name = "Full Stack Engineers",
        },
        CompanyId = "23456",
        CompanyName = "SpaceX",
        EmploymentStartDate = "2021-10-26",
        EmploymentEndDate = "2028-10-26",
        LeavingReason = LeavingReason.Resigned,
        EmployeeNumber = "123456-AB",
        EmploymentStatus = EmploymentStatus.Active,
        Ethnicity = "African American",
        Manager = new Manager() {
            Id = "12345",
            Name = "Elon Musk",
            FirstName = "Elon",
            LastName = "Musk",
            Email = "elon@musk.com",
            EmploymentStatus = EmploymentStatus.Active,
        },
        DirectReports = new List<string>() {
            "a0d636c6-43b3-4bde-8c70-85b707d992f4",
            "a98lfd96-43b3-4bde-8c70-85b707d992e6",
        },
        SocialSecurityNumber = "123456789",
        Birthday = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
        DeceasedOn = LocalDate.FromDateTime(System.DateTime.Parse("2000-08-12")),
        CountryOfBirth = "US",
        Description = "A description",
        Gender = Gender.Male,
        Pronouns = "she,her",
        PreferredLanguage = "EN",
        Languages = new List<string>() {
            "EN",
        },
        Nationalities = new List<string>() {
            "US",
        },
        PhotoUrl = "https://unavatar.io/elon-musk",
        Timezone = "Europe/London",
        Source = "lever",
        SourceId = "12345",
        RecordUrl = "https://app.intercom.io/contacts/12345",
        Jobs = new List<EmployeeJobInput>() {
            new EmployeeJobInput() {
                Title = "CEO",
                Role = "Sales",
                StartDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-08-12")),
                EndDate = LocalDate.FromDateTime(System.DateTime.Parse("2020-08-12")),
                CompensationRate = 72000D,
                Currency = Currency.Usd,
                PaymentUnit = PaymentUnit.Year,
                HiredAt = LocalDate.FromDateTime(System.DateTime.Parse("2020-08-12")),
                IsPrimary = true,
                IsManager = true,
                Status = EmployeeJobStatus.Active,
                Location = new Address() {
                    Id = "123",
                    Type = ApideckUnifySdk.Models.Components.Type.Primary,
                    String = "25 Spring Street, Blackburn, VIC 3130",
                    Name = "HQ US",
                    Line1 = "Main street",
                    Line2 = "apt #",
                    Line3 = "Suite #",
                    Line4 = "delivery instructions",
                    StreetNumber = "25",
                    City = "San Francisco",
                    State = "CA",
                    PostalCode = "94104",
                    Country = "US",
                    Latitude = "40.759211",
                    Longitude = "-73.984638",
                    County = "Santa Clara",
                    ContactName = "Elon Musk",
                    Salutation = "Mr",
                    PhoneNumber = "111-111-1111",
                    Fax = "122-111-1111",
                    Email = "elon@musk.com",
                    Website = "https://elonmusk.com",
                    Notes = "Address notes or delivery instructions.",
                    RowVersion = "1-12345",
                },
            },
        },
        Compensations = new List<EmployeeCompensationInput>() {
            new EmployeeCompensationInput() {
                Rate = 50D,
                PaymentUnit = PaymentUnit.Hour,
                FlsaStatus = FlsaStatus.Nonexempt,
                EffectiveDate = "2021-06-11",
            },
        },
        WorksRemote = true,
        Addresses = new List<Address>() {
            new Address() {
                Id = "123",
                Type = ApideckUnifySdk.Models.Components.Type.Primary,
                String = "25 Spring Street, Blackburn, VIC 3130",
                Name = "HQ US",
                Line1 = "Main street",
                Line2 = "apt #",
                Line3 = "Suite #",
                Line4 = "delivery instructions",
                StreetNumber = "25",
                City = "San Francisco",
                State = "CA",
                PostalCode = "94104",
                Country = "US",
                Latitude = "40.759211",
                Longitude = "-73.984638",
                County = "Santa Clara",
                ContactName = "Elon Musk",
                Salutation = "Mr",
                PhoneNumber = "111-111-1111",
                Fax = "122-111-1111",
                Email = "elon@musk.com",
                Website = "https://elonmusk.com",
                Notes = "Address notes or delivery instructions.",
                RowVersion = "1-12345",
            },
        },
        PhoneNumbers = new List<PhoneNumber>() {
            new PhoneNumber() {
                Id = "12345",
                CountryCode = "1",
                AreaCode = "323",
                Number = "111-111-1111",
                Extension = "105",
                Type = PhoneNumberType.Primary,
            },
        },
        Emails = new List<Email>() {
            new Email() {
                Id = "123",
                Email = "elon@musk.com",
                Type = EmailType.Primary,
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
        SocialLinks = new List<SocialLink>() {
            new SocialLink() {
                Id = "12345",
                Url = "https://www.twitter.com/apideck",
                Type = "twitter",
            },
        },
        BankAccounts = new List<BankAccount>() {
            new BankAccount() {
                BankName = "Monzo",
                AccountNumber = "123465",
                AccountName = "SPACEX LLC",
                AccountType = AccountType.CreditCard,
                Iban = "CH2989144532982975332",
                Bic = "AUDSCHGGXXX",
                RoutingNumber = "012345678",
                BsbNumber = "062-001",
                BranchIdentifier = "001",
                BankCode = "BNH",
                Currency = Currency.Usd,
            },
        },
        TaxCode = "1111",
        TaxId = "234-32-0000",
        DietaryPreference = "Veggie",
        FoodAllergies = new List<string>() {
            "No allergies",
        },
        ProbationPeriod = new ProbationPeriod() {
            StartDate = LocalDate.FromDateTime(System.DateTime.Parse("2021-10-01")),
            EndDate = LocalDate.FromDateTime(System.DateTime.Parse("2021-11-28")),
        },
        Tags = new List<string>() {
            "New",
        },
        RowVersion = "1-12345",
        Deleted = true,
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

var res = await sdk.Hris.Employees.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisEmployeesUpdateRequest](../../Models/Requests/HrisEmployeesUpdateRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisEmployeesUpdateResponse](../../Models/Requests/HrisEmployeesUpdateResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |

## Delete

Delete Employee

### Example Usage

```csharp
using ApideckUnifySdk;
using ApideckUnifySdk.Models.Components;
using ApideckUnifySdk.Models.Requests;

var sdk = new Apideck(
    apiKey: "<YOUR_BEARER_TOKEN_HERE>",
    consumerId: "test-consumer",
    appId: "dSBdXd2H6Mqwfg0atXHXYcysLJE9qyn1VwBtXHX"
);

HrisEmployeesDeleteRequest req = new HrisEmployeesDeleteRequest() {
    Id = "<id>",
    ServiceId = "salesforce",
};

var res = await sdk.Hris.Employees.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisEmployeesDeleteRequest](../../Models/Requests/HrisEmployeesDeleteRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisEmployeesDeleteResponse](../../Models/Requests/HrisEmployeesDeleteResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| ApideckUnifySdk.Models.Errors.BadRequestResponse      | 400                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnauthorizedResponse    | 401                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.PaymentRequiredResponse | 402                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.NotFoundResponse        | 404                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.UnprocessableResponse   | 422                                                   | application/json                                      |
| ApideckUnifySdk.Models.Errors.APIException            | 4XX, 5XX                                              | \*/\*                                                 |