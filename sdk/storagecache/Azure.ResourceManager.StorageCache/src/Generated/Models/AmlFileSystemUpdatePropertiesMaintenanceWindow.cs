// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Start time of a 30-minute weekly maintenance window. </summary>
    public partial class AmlFileSystemUpdatePropertiesMaintenanceWindow
    {
        /// <summary> Initializes a new instance of <see cref="AmlFileSystemUpdatePropertiesMaintenanceWindow"/>. </summary>
        public AmlFileSystemUpdatePropertiesMaintenanceWindow()
        {
        }

        /// <summary> Day of the week on which the maintenance window will occur. </summary>
        public MaintenanceDayOfWeekType? DayOfWeek { get; set; }
        /// <summary> The time of day (in UTC) to start the maintenance window. </summary>
        public string TimeOfDayUTC { get; set; }
    }
}
