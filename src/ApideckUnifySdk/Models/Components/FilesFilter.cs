//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace ApideckUnifySdk.Models.Components
{
    using ApideckUnifySdk.Utils;
    
    public class FilesFilter
    {

        /// <summary>
        /// ID of the drive to filter on
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=drive_id")]
        public string? DriveId { get; set; }

        /// <summary>
        /// ID of the folder to filter on. The root folder has an alias &quot;root&quot;
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Only return files and folders that are shared
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=shared")]
        public bool? Shared { get; set; }
    }
}