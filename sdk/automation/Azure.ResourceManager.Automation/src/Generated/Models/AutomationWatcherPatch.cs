// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The AutomationWatcherPatch. </summary>
    public partial class AutomationWatcherPatch
    {
        /// <summary> Initializes a new instance of <see cref="AutomationWatcherPatch"/>. </summary>
        public AutomationWatcherPatch()
        {
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the frequency at which the watcher is invoked. </summary>
        public long? ExecutionFrequencyInSeconds { get; set; }
    }
}
