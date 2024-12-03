# VirtualWebhooks

Virtual webhook config for the connector.


## Fields

| Field                                                                                             | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `RequestRate`                                                                                     | [RequestRate](../../Models/Components/RequestRate.md)                                             | :heavy_check_mark:                                                                                | The rate at which requests for resources will be made to downstream.                              |
| `Resources`                                                                                       | Dictionary<String, [WebhookSupportResources](../../Models/Components/WebhookSupportResources.md)> | :heavy_minus_sign:                                                                                | The resources that will be requested from downstream.                                             |