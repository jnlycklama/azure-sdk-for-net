// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating triggers. </summary>
    public partial class ContainerRegistryTriggerUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTriggerUpdateContent"/>. </summary>
        public ContainerRegistryTriggerUpdateContent()
        {
            TimerTriggers = new ChangeTrackingList<ContainerRegistryTimerTriggerUpdateContent>();
            SourceTriggers = new ChangeTrackingList<ContainerRegistrySourceTriggerUpdateContent>();
        }

        /// <summary> The collection of timer triggers. </summary>
        public IList<ContainerRegistryTimerTriggerUpdateContent> TimerTriggers { get; }
        /// <summary> The collection of triggers based on source code repository. </summary>
        public IList<ContainerRegistrySourceTriggerUpdateContent> SourceTriggers { get; }
        /// <summary> The trigger based on base image dependencies. </summary>
        public ContainerRegistryBaseImageTriggerUpdateContent BaseImageTrigger { get; set; }
    }
}
