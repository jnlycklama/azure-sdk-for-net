// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The authentication client credentials of the custom Open ID Connect provider. </summary>
    public partial class ContainerAppOpenIdConnectClientCredential
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectClientCredential"/>. </summary>
        public ContainerAppOpenIdConnectClientCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectClientCredential"/>. </summary>
        /// <param name="method"> The method that should be used to authenticate the user. </param>
        /// <param name="clientSecretSettingName"> The app setting that contains the client secret for the custom Open ID Connect provider. </param>
        internal ContainerAppOpenIdConnectClientCredential(ContainerAppOpenIdConnectClientCredentialMethod? method, string clientSecretSettingName)
        {
            Method = method;
            ClientSecretSettingName = clientSecretSettingName;
        }

        /// <summary> The method that should be used to authenticate the user. </summary>
        public ContainerAppOpenIdConnectClientCredentialMethod? Method { get; set; }
        /// <summary> The app setting that contains the client secret for the custom Open ID Connect provider. </summary>
        public string ClientSecretSettingName { get; set; }
    }
}
