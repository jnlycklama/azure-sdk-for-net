// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Result of the request to list tags of the image. </summary>
    internal partial class RepositoryTags
    {
        /// <summary> Initializes a new instance of <see cref="RepositoryTags"/>. </summary>
        internal RepositoryTags()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Name of the image. </summary>
        public string Name { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
    }
}
