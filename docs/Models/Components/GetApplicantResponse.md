# GetApplicantResponse

Applicants


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `StatusCode`                                      | *long*                                            | :heavy_check_mark:                                | HTTP Response Status Code                         | 200                                               |
| `Status`                                          | *string*                                          | :heavy_check_mark:                                | HTTP Response Status                              | OK                                                |
| `Service`                                         | *string*                                          | :heavy_check_mark:                                | Apideck ID of service provider                    | lever                                             |
| `Resource`                                        | *string*                                          | :heavy_check_mark:                                | Unified API resource name                         | Applicants                                        |
| `Operation`                                       | *string*                                          | :heavy_check_mark:                                | Operation performed                               | one                                               |
| `Data`                                            | [Applicant](../../Models/Components/Applicant.md) | :heavy_check_mark:                                | N/A                                               |                                                   |