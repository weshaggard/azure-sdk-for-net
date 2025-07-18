// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedCache.Models
{
    /// <summary> Customer resource transit states. </summary>
    public readonly partial struct CustomerTransitState : IEquatable<CustomerTransitState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomerTransitState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomerTransitState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoTransitValue = "NoTransit";
        private const string CombinedTransitValue = "CombinedTransit";
        private const string TransitOnlyValue = "TransitOnly";

        /// <summary> do not have transit. </summary>
        public static CustomerTransitState NoTransit { get; } = new CustomerTransitState(NoTransitValue);
        /// <summary> transit provider and have own subscribers. </summary>
        public static CustomerTransitState CombinedTransit { get; } = new CustomerTransitState(CombinedTransitValue);
        /// <summary> pure transit provider or network service provider. </summary>
        public static CustomerTransitState TransitOnly { get; } = new CustomerTransitState(TransitOnlyValue);
        /// <summary> Determines if two <see cref="CustomerTransitState"/> values are the same. </summary>
        public static bool operator ==(CustomerTransitState left, CustomerTransitState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomerTransitState"/> values are not the same. </summary>
        public static bool operator !=(CustomerTransitState left, CustomerTransitState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CustomerTransitState"/>. </summary>
        public static implicit operator CustomerTransitState(string value) => new CustomerTransitState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomerTransitState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomerTransitState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
