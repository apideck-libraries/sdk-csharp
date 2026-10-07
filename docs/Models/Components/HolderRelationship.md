# HolderRelationship

The holder's relationship to the account.

## Example Usage

```csharp
using ApideckUnifySdk.Models.Components;

var value = HolderRelationship.AuthorizedSigner;

// Open enum: use .Of() to create instances from custom string values
var custom = HolderRelationship.Of("custom_value");
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `AuthorizedSigner`                        | authorized_signer                         |
| `AuthorizedUser`                          | authorized_user                           |
| `Business`                                | business                                  |
| `ForBenefitOf`                            | for_benefit_of                            |
| `ForBenefitOfPrimary`                     | for_benefit_of_primary                    |
| `ForBenefitOfPrimaryJointRestricted`      | for_benefit_of_primary_joint_restricted   |
| `ForBenefitOfSecondary`                   | for_benefit_of_secondary                  |
| `ForBenefitOfSecondaryJointRestricted`    | for_benefit_of_secondary_joint_restricted |
| `ForBenefitOfSoleOwnerRestricted`         | for_benefit_of_sole_owner_restricted      |
| `PowerOfAttorney`                         | power_of_attorney                         |
| `Primary`                                 | primary                                   |
| `PrimaryBorrower`                         | primary_borrower                          |
| `PrimaryJoint`                            | primary_joint                             |
| `PrimaryJointTenants`                     | primary_joint_tenants                     |
| `Secondary`                               | secondary                                 |
| `SecondaryBorrower`                       | secondary_borrower                        |
| `SecondaryJoint`                          | secondary_joint                           |
| `SecondaryJointTenants`                   | secondary_joint_tenants                   |
| `SoleOwner`                               | sole_owner                                |
| `Trustee`                                 | trustee                                   |
| `UniformTransferToMinor`                  | uniform_transfer_to_minor                 |