// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace StableDiffusionWebUI.Client.Models
{
    /// <summary> Sets the resize mode: 0 to upscale by upscaling_resize amount, 1 to upscale up to upscaling_resize_h x upscaling_resize_w. </summary>
    public readonly partial struct ExtrasBatchImagesRequestResizeMode : IEquatable<ExtrasBatchImagesRequestResizeMode>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="ExtrasBatchImagesRequestResizeMode"/>. </summary>
        public ExtrasBatchImagesRequestResizeMode(int value)
        {
            _value = value;
        }

        private const int ZeroValue = 0;
        private const int OneValue = 1;

        /// <summary> 0. </summary>
        public static ExtrasBatchImagesRequestResizeMode Zero { get; } = new ExtrasBatchImagesRequestResizeMode(ZeroValue);
        /// <summary> 1. </summary>
        public static ExtrasBatchImagesRequestResizeMode One { get; } = new ExtrasBatchImagesRequestResizeMode(OneValue);
        /// <summary> Determines if two <see cref="ExtrasBatchImagesRequestResizeMode"/> values are the same. </summary>
        public static bool operator ==(ExtrasBatchImagesRequestResizeMode left, ExtrasBatchImagesRequestResizeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExtrasBatchImagesRequestResizeMode"/> values are not the same. </summary>
        public static bool operator !=(ExtrasBatchImagesRequestResizeMode left, ExtrasBatchImagesRequestResizeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExtrasBatchImagesRequestResizeMode"/>. </summary>
        public static implicit operator ExtrasBatchImagesRequestResizeMode(int value) => new ExtrasBatchImagesRequestResizeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExtrasBatchImagesRequestResizeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExtrasBatchImagesRequestResizeMode other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
