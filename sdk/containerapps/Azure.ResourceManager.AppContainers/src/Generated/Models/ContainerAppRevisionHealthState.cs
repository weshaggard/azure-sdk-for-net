// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Current health State of the revision. </summary>
    public readonly partial struct ContainerAppRevisionHealthState : IEquatable<ContainerAppRevisionHealthState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionHealthState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppRevisionHealthState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HealthyValue = "Healthy";
        private const string UnhealthyValue = "Unhealthy";
        private const string NoneValue = "None";

        /// <summary> Healthy. </summary>
        public static ContainerAppRevisionHealthState Healthy { get; } = new ContainerAppRevisionHealthState(HealthyValue);
        /// <summary> Unhealthy. </summary>
        public static ContainerAppRevisionHealthState Unhealthy { get; } = new ContainerAppRevisionHealthState(UnhealthyValue);
        /// <summary> None. </summary>
        public static ContainerAppRevisionHealthState None { get; } = new ContainerAppRevisionHealthState(NoneValue);
        /// <summary> Determines if two <see cref="ContainerAppRevisionHealthState"/> values are the same. </summary>
        public static bool operator ==(ContainerAppRevisionHealthState left, ContainerAppRevisionHealthState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppRevisionHealthState"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppRevisionHealthState left, ContainerAppRevisionHealthState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppRevisionHealthState"/>. </summary>
        public static implicit operator ContainerAppRevisionHealthState(string value) => new ContainerAppRevisionHealthState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppRevisionHealthState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppRevisionHealthState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
