// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> Defines the list of the warning codes. </summary>
    public readonly partial struct WarningCode : IEquatable<WarningCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WarningCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WarningCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LongWordsInDocumentValue = "LongWordsInDocument";
        private const string DocumentTruncatedValue = "DocumentTruncated";

        /// <summary> Long words in document warning. </summary>
        public static WarningCode LongWordsInDocument { get; } = new WarningCode(LongWordsInDocumentValue);
        /// <summary> Document truncated warning. </summary>
        public static WarningCode DocumentTruncated { get; } = new WarningCode(DocumentTruncatedValue);
        /// <summary> Determines if two <see cref="WarningCode"/> values are the same. </summary>
        public static bool operator ==(WarningCode left, WarningCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WarningCode"/> values are not the same. </summary>
        public static bool operator !=(WarningCode left, WarningCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WarningCode"/>. </summary>
        public static implicit operator WarningCode(string value) => new WarningCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WarningCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WarningCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
