// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Whether the location is primary or failover. </summary>
    public readonly partial struct DeviceUpdateAccountLocationRole : IEquatable<DeviceUpdateAccountLocationRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceUpdateAccountLocationRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceUpdateAccountLocationRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string FailoverValue = "Failover";

        /// <summary> Primary. </summary>
        public static DeviceUpdateAccountLocationRole Primary { get; } = new DeviceUpdateAccountLocationRole(PrimaryValue);
        /// <summary> Failover. </summary>
        public static DeviceUpdateAccountLocationRole Failover { get; } = new DeviceUpdateAccountLocationRole(FailoverValue);
        /// <summary> Determines if two <see cref="DeviceUpdateAccountLocationRole"/> values are the same. </summary>
        public static bool operator ==(DeviceUpdateAccountLocationRole left, DeviceUpdateAccountLocationRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceUpdateAccountLocationRole"/> values are not the same. </summary>
        public static bool operator !=(DeviceUpdateAccountLocationRole left, DeviceUpdateAccountLocationRole right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeviceUpdateAccountLocationRole"/>. </summary>
        public static implicit operator DeviceUpdateAccountLocationRole(string value) => new DeviceUpdateAccountLocationRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceUpdateAccountLocationRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceUpdateAccountLocationRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
