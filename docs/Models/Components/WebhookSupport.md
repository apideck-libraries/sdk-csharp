# WebhookSupport

How webhooks are supported for the connector. Sometimes the connector natively supports webhooks, other times Apideck virtualizes them based on polling.


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Mode`                                                            | [Mode](../../Models/Components/Mode.md)                           | :heavy_minus_sign:                                                | Mode of the webhook support.                                      | native                                                            |
| `SubscriptionLevel`                                               | [SubscriptionLevel](../../Models/Components/SubscriptionLevel.md) | :heavy_minus_sign:                                                | Received events are scoped to connection or across integration.   | integration                                                       |
| `ManagedVia`                                                      | [ManagedVia](../../Models/Components/ManagedVia.md)               | :heavy_minus_sign:                                                | How the subscription is managed in the downstream.                | api                                                               |
| `VirtualWebhooks`                                                 | [VirtualWebhooks](../../Models/Components/VirtualWebhooks.md)     | :heavy_minus_sign:                                                | Virtual webhook config for the connector.                         |                                                                   |