# LinkedEcommerceOrder

The order this entity is linked to.


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Id`                                                                    | *string*                                                                | :heavy_minus_sign:                                                      | A unique identifier for an object.                                      | 12345                                                                   |
| `Total`                                                                 | *string*                                                                | :heavy_minus_sign:                                                      | The total amount of the order.                                          | 199.99                                                                  |
| `Status`                                                                | [EcommerceOrderStatus](../../Models/Components/EcommerceOrderStatus.md) | :heavy_minus_sign:                                                      | Current status of the order.                                            | active                                                                  |