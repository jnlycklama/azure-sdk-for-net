// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Update migration item input. </summary>
    public partial class SiteRecoveryMigrationItemPatch
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryMigrationItemPatch"/>. </summary>
        public SiteRecoveryMigrationItemPatch()
        {
        }

        /// <summary> Update migration item input properties. </summary>
        internal UpdateMigrationItemProperties Properties { get; set; }
        /// <summary>
        /// The provider specific input to update migration item.
        /// Please note <see cref="UpdateMigrationItemProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtUpdateMigrationItemContent"/>.
        /// </summary>
        public UpdateMigrationItemProviderSpecificContent UpdateMigrationItemProviderSpecificDetails
        {
            get => Properties is null ? default : Properties.ProviderSpecificDetails;
            set => Properties = new UpdateMigrationItemProperties(value);
        }
    }
}
