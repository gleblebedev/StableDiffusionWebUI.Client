// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    /// <summary> PNGInfoResponse. </summary>
    public partial class PNGInfoResponse
    {
        /// <summary> Initializes a new instance of PNGInfoResponse. </summary>
        /// <param name="info"> A string with all the info the image had. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        internal PNGInfoResponse(string info)
        {
            Argument.AssertNotNull(info, nameof(info));

            Info = info;
        }

        /// <summary> A string with all the info the image had. </summary>
        public string Info { get; }
    }
}
