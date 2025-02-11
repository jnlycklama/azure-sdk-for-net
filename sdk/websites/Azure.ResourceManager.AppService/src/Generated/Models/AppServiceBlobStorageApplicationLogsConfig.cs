// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs azure blob storage configuration. </summary>
    public partial class AppServiceBlobStorageApplicationLogsConfig
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageApplicationLogsConfig"/>. </summary>
        public AppServiceBlobStorageApplicationLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageApplicationLogsConfig"/>. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUri"> SAS url to a azure blob container with read/write/list/delete permissions. </param>
        /// <param name="retentionInDays">
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </param>
        internal AppServiceBlobStorageApplicationLogsConfig(WebAppLogLevel? level, Uri sasUri, int? retentionInDays)
        {
            Level = level;
            SasUri = sasUri;
            RetentionInDays = retentionInDays;
        }

        /// <summary> Log level. </summary>
        public WebAppLogLevel? Level { get; set; }
        /// <summary> SAS url to a azure blob container with read/write/list/delete permissions. </summary>
        public Uri SasUri { get; set; }
        /// <summary>
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        public int? RetentionInDays { get; set; }
    }
}
