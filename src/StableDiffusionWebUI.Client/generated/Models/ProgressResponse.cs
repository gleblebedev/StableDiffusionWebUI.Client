// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    /// <summary> ProgressResponse. </summary>
    public partial class ProgressResponse
    {
        /// <summary> Initializes a new instance of ProgressResponse. </summary>
        /// <param name="progress"> The progress with a range of 0 to 1. </param>
        /// <param name="etaRelative"> ETA in secs. </param>
        /// <param name="state"> The current state snapshot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="state"/> is null. </exception>
        internal ProgressResponse(float progress, float etaRelative, object state)
        {
            Argument.AssertNotNull(state, nameof(state));

            Progress = progress;
            EtaRelative = etaRelative;
            State = state;
        }

        /// <summary> Initializes a new instance of ProgressResponse. </summary>
        /// <param name="progress"> The progress with a range of 0 to 1. </param>
        /// <param name="etaRelative"> ETA in secs. </param>
        /// <param name="state"> The current state snapshot. </param>
        /// <param name="currentImage"> The current image in base64 format. opts.show_progress_every_n_steps is required for this to work. </param>
        internal ProgressResponse(float progress, float etaRelative, object state, string currentImage)
        {
            Progress = progress;
            EtaRelative = etaRelative;
            State = state;
            CurrentImage = currentImage;
        }

        /// <summary> The progress with a range of 0 to 1. </summary>
        public float Progress { get; }
        /// <summary> ETA in secs. </summary>
        public float EtaRelative { get; }
        /// <summary> The current state snapshot. </summary>
        public object State { get; }
        /// <summary> The current image in base64 format. opts.show_progress_every_n_steps is required for this to work. </summary>
        public string CurrentImage { get; }
    }
}
