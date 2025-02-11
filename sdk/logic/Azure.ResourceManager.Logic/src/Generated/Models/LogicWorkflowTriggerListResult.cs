// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of workflow triggers. </summary>
    internal partial class LogicWorkflowTriggerListResult
    {
        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerListResult"/>. </summary>
        internal LogicWorkflowTriggerListResult()
        {
            Value = new ChangeTrackingList<LogicWorkflowTriggerData>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerListResult"/>. </summary>
        /// <param name="value"> A list of workflow triggers. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal LogicWorkflowTriggerListResult(IReadOnlyList<LogicWorkflowTriggerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of workflow triggers. </summary>
        public IReadOnlyList<LogicWorkflowTriggerData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
