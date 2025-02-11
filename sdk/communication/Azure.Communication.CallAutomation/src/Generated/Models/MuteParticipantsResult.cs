// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for muting participants from the call. </summary>
    public partial class MuteParticipantsResult
    {
        /// <summary> Initializes a new instance of <see cref="MuteParticipantsResult"/>. </summary>
        internal MuteParticipantsResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MuteParticipantsResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        internal MuteParticipantsResult(string operationContext)
        {
            OperationContext = operationContext;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
