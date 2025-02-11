// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Provider specific switch provider input.
    /// Please note <see cref="SwitchProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="InMageAzureV2SwitchProviderContent"/>.
    /// </summary>
    public abstract partial class SwitchProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="SwitchProviderSpecificContent"/>. </summary>
        protected SwitchProviderSpecificContent()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
