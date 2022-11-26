// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    /// <summary> ImageToImageResponse. </summary>
    public partial class ImageToImageResponse
    {
        /// <summary> Initializes a new instance of ImageToImageResponse. </summary>
        /// <param name="parameters"> Parameters. </param>
        /// <param name="info"> Info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> or <paramref name="info"/> is null. </exception>
        internal ImageToImageResponse(object parameters, string info)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(info, nameof(info));

            Images = new ChangeTrackingList<string>();
            Parameters = parameters;
            Info = info;
        }

        /// <summary> Initializes a new instance of ImageToImageResponse. </summary>
        /// <param name="images"> The generated image in base64 format. </param>
        /// <param name="parameters"> Parameters. </param>
        /// <param name="info"> Info. </param>
        internal ImageToImageResponse(IReadOnlyList<string> images, object parameters, string info)
        {
            Images = images;
            Parameters = parameters;
            Info = info;
        }

        /// <summary> The generated image in base64 format. </summary>
        public IReadOnlyList<string> Images { get; }
        /// <summary> Parameters. </summary>
        public object Parameters { get; }
        /// <summary> Info. </summary>
        public string Info { get; }
    }
}
