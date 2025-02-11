// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Represents the request data used to generate images. </summary>
    public partial class ImageGenerationOptions
    {
        /// <summary> Initializes a new instance of <see cref="ImageGenerationOptions"/>. </summary>
        /// <param name="prompt"> A description of the desired images. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prompt"/> is null. </exception>
        public ImageGenerationOptions(string prompt)
        {
            Argument.AssertNotNull(prompt, nameof(prompt));

            Prompt = prompt;
        }

        /// <summary> Initializes a new instance of <see cref="ImageGenerationOptions"/>. </summary>
        /// <param name="prompt"> A description of the desired images. </param>
        /// <param name="imageCount"> The number of images to generate (defaults to 1). </param>
        /// <param name="size"> The desired size of the generated images. Must be one of 256x256, 512x512, or 1024x1024 (defaults to 1024x1024). </param>
        /// <param name="responseFormat">
        ///   The format in which image generation response items should be presented.
        ///   Azure OpenAI only supports URL response items.
        /// </param>
        /// <param name="user"> A unique identifier representing your end-user, which can help to monitor and detect abuse. </param>
        internal ImageGenerationOptions(string prompt, int? imageCount, ImageSize? size, ImageGenerationResponseFormat? responseFormat, string user)
        {
            Prompt = prompt;
            ImageCount = imageCount;
            Size = size;
            ResponseFormat = responseFormat;
            User = user;
        }
        /// <summary> The number of images to generate (defaults to 1). </summary>
        public int? ImageCount { get; set; }
        /// <summary> The desired size of the generated images. Must be one of 256x256, 512x512, or 1024x1024 (defaults to 1024x1024). </summary>
        public ImageSize? Size { get; set; }
        /// <summary> A unique identifier representing your end-user, which can help to monitor and detect abuse. </summary>
        public string User { get; set; }
    }
}
