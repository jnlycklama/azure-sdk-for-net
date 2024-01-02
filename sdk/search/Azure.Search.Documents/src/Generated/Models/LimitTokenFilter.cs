// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Limits the number of tokens while indexing. This token filter is implemented using Apache Lucene. </summary>
    public partial class LimitTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="LimitTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LimitTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.LimitTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="LimitTokenFilter"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="maxTokenCount"> The maximum number of tokens to produce. Default is 1. </param>
        /// <param name="consumeAllTokens"> A value indicating whether all tokens from the input must be consumed even if maxTokenCount is reached. Default is false. </param>
        internal LimitTokenFilter(string oDataType, string name, int? maxTokenCount, bool? consumeAllTokens) : base(oDataType, name)
        {
            MaxTokenCount = maxTokenCount;
            ConsumeAllTokens = consumeAllTokens;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.LimitTokenFilter";
        }

        /// <summary> The maximum number of tokens to produce. Default is 1. </summary>
        public int? MaxTokenCount { get; set; }
        /// <summary> A value indicating whether all tokens from the input must be consumed even if maxTokenCount is reached. Default is false. </summary>
        public bool? ConsumeAllTokens { get; set; }
    }
}
