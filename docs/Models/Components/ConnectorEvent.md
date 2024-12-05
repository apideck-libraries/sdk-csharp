# ConnectorEvent

Unify event that is supported on the connector. Events are delivered via Webhooks.


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `EventType`                                           | *string*                                              | :heavy_minus_sign:                                    | Unify event type                                      | employee.created                                      |
| `EventSource`                                         | [EventSource](../../Models/Components/EventSource.md) | :heavy_minus_sign:                                    | Unify event source                                    | native                                                |
| `DownstreamEventType`                                 | *string*                                              | :heavy_minus_sign:                                    | Downstream event type                                 | person_created                                        |
| `Resources`                                           | List<*string*>                                        | :heavy_minus_sign:                                    | N/A                                                   |                                                       |
| `EntityType`                                          | *string*                                              | :heavy_minus_sign:                                    | Unify entity type                                     | employee                                              |