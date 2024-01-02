// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines a combination of configurations to use with vector search. </summary>
    public partial class VectorSearchProfile
    {
        /// <summary> Initializes a new instance of <see cref="VectorSearchProfile"/>. </summary>
        /// <param name="name"> The name to associate with this particular vector search profile. </param>
        /// <param name="algorithm"> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="algorithm"/> is null. </exception>
        public VectorSearchProfile(string name, string algorithm)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(algorithm, nameof(algorithm));

            Name = name;
            Algorithm = algorithm;
        }

        /// <summary> Initializes a new instance of <see cref="VectorSearchProfile"/>. </summary>
        /// <param name="name"> The name to associate with this particular vector search profile. </param>
        /// <param name="algorithm"> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </param>
        /// <param name="vectorizer"> The name of the kind of vectorization method being configured for use with vector search. </param>
        internal VectorSearchProfile(string name, string algorithm, string vectorizer)
        {
            Name = name;
            Algorithm = algorithm;
            Vectorizer = vectorizer;
        }

        /// <summary> The name to associate with this particular vector search profile. </summary>
        public string Name { get; set; }
        /// <summary> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </summary>
        public string Algorithm { get; set; }
        /// <summary> The name of the kind of vectorization method being configured for use with vector search. </summary>
        public string Vectorizer { get; set; }
    }
}
