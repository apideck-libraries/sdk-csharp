# LinkedEcommerceCustomer

The customer this entity is linked to.


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | The ID of the customer this entity is linked to.            | 12345                                                       |
| `Name`                                                      | *string*                                                    | :heavy_minus_sign:                                          | Full name of the customer                                   | John Doe                                                    |
| `FirstName`                                                 | *string*                                                    | :heavy_minus_sign:                                          | First name of the customer                                  | John                                                        |
| `LastName`                                                  | *string*                                                    | :heavy_minus_sign:                                          | Last name of the customer                                   | Doe                                                         |
| `CompanyName`                                               | *string*                                                    | :heavy_minus_sign:                                          | Company name of the customer                                | Acme Inc.                                                   |
| `PhoneNumbers`                                              | List<[PhoneNumber](../../Models/Components/PhoneNumber.md)> | :heavy_minus_sign:                                          | N/A                                                         |                                                             |
| `Emails`                                                    | List<[Email](../../Models/Components/Email.md)>             | :heavy_minus_sign:                                          | N/A                                                         |                                                             |