// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The LiveEvent action input parameter definition. </summary>
    public partial class LiveEventActionContent
    {
        /// <summary> Initializes a new instance of <see cref="LiveEventActionContent"/>. </summary>
        public LiveEventActionContent()
        {
        }

        /// <summary> The flag indicates whether live outputs are automatically deleted when live event is being stopped. Deleting live outputs do not delete the underlying assets. </summary>
        public bool? RemoveOutputsOnStop { get; set; }
    }
}
