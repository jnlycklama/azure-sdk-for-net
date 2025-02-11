// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An array of available service aliases. </summary>
    internal partial class AvailableServiceAliasesResult
    {
        /// <summary> Initializes a new instance of <see cref="AvailableServiceAliasesResult"/>. </summary>
        internal AvailableServiceAliasesResult()
        {
            Value = new ChangeTrackingList<AvailableServiceAlias>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableServiceAliasesResult"/>. </summary>
        /// <param name="value"> An array of available service aliases. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal AvailableServiceAliasesResult(IReadOnlyList<AvailableServiceAlias> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of available service aliases. </summary>
        public IReadOnlyList<AvailableServiceAlias> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
