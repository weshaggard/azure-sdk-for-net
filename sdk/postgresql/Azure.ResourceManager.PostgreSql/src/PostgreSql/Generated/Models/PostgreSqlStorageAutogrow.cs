// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Enable Storage Auto Grow. </summary>
    public readonly partial struct PostgreSqlStorageAutogrow : IEquatable<PostgreSqlStorageAutogrow>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlStorageAutogrow"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlStorageAutogrow(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PostgreSqlStorageAutogrow Enabled { get; } = new PostgreSqlStorageAutogrow(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlStorageAutogrow Disabled { get; } = new PostgreSqlStorageAutogrow(DisabledValue);
        /// <summary> Determines if two <see cref="PostgreSqlStorageAutogrow"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlStorageAutogrow left, PostgreSqlStorageAutogrow right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlStorageAutogrow"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlStorageAutogrow left, PostgreSqlStorageAutogrow right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlStorageAutogrow"/>. </summary>
        public static implicit operator PostgreSqlStorageAutogrow(string value) => new PostgreSqlStorageAutogrow(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlStorageAutogrow other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlStorageAutogrow other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
