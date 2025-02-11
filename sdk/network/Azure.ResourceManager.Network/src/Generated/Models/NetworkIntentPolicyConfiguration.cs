// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details of NetworkIntentPolicyConfiguration for PrepareNetworkPoliciesRequest. </summary>
    public partial class NetworkIntentPolicyConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="NetworkIntentPolicyConfiguration"/>. </summary>
        public NetworkIntentPolicyConfiguration()
        {
        }

        /// <summary> The name of the Network Intent Policy for storing in target subscription. </summary>
        public string NetworkIntentPolicyName { get; set; }
        /// <summary> Source network intent policy. </summary>
        public NetworkIntentPolicy SourceNetworkIntentPolicy { get; set; }
    }
}
