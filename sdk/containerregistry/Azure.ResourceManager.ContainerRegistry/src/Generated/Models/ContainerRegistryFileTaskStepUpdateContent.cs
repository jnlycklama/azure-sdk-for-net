// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of updating a task step. </summary>
    public partial class ContainerRegistryFileTaskStepUpdateContent : ContainerRegistryTaskStepUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryFileTaskStepUpdateContent"/>. </summary>
        public ContainerRegistryFileTaskStepUpdateContent()
        {
            Values = new ChangeTrackingList<ContainerRegistryTaskOverridableValue>();
            StepType = ContainerRegistryTaskStepType.FileTask;
        }

        /// <summary> The task template/definition file path relative to the source context. </summary>
        public string TaskFilePath { get; set; }
        /// <summary> The values/parameters file path relative to the source context. </summary>
        public string ValuesFilePath { get; set; }
        /// <summary> The collection of overridable values that can be passed when running a task. </summary>
        public IList<ContainerRegistryTaskOverridableValue> Values { get; }
    }
}
