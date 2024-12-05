# FilesFilter


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        | Example                                                            |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `DriveId`                                                          | *string*                                                           | :heavy_minus_sign:                                                 | ID of the drive to filter on                                       | 1234                                                               |
| `FolderId`                                                         | *string*                                                           | :heavy_minus_sign:                                                 | ID of the folder to filter on. The root folder has an alias "root" | root                                                               |
| `Shared`                                                           | *bool*                                                             | :heavy_minus_sign:                                                 | Only return files and folders that are shared                      | true                                                               |