// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> OAuth acquire token request body parameter (www-url-form-encoded). </summary>
    public partial class TokenBodyParameterContract
    {
        /// <summary> Initializes a new instance of <see cref="TokenBodyParameterContract"/>. </summary>
        /// <param name="name"> body parameter name. </param>
        /// <param name="value"> body parameter value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public TokenBodyParameterContract(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> body parameter name. </summary>
        public string Name { get; set; }
        /// <summary> body parameter value. </summary>
        public string Value { get; set; }
    }
}
