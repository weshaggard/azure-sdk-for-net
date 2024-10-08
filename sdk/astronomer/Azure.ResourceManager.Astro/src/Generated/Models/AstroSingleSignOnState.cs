// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Astro.Models
{
    /// <summary> Various states of the SSO resource. </summary>
    public readonly partial struct AstroSingleSignOnState : IEquatable<AstroSingleSignOnState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AstroSingleSignOnState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AstroSingleSignOnState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitialValue = "Initial";
        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Initial state of the SSO resource. </summary>
        public static AstroSingleSignOnState Initial { get; } = new AstroSingleSignOnState(InitialValue);
        /// <summary> State of the SSO resource when it is enabled. </summary>
        public static AstroSingleSignOnState Enable { get; } = new AstroSingleSignOnState(EnableValue);
        /// <summary> State of the SSO resource when it is disabled. </summary>
        public static AstroSingleSignOnState Disable { get; } = new AstroSingleSignOnState(DisableValue);
        /// <summary> Determines if two <see cref="AstroSingleSignOnState"/> values are the same. </summary>
        public static bool operator ==(AstroSingleSignOnState left, AstroSingleSignOnState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AstroSingleSignOnState"/> values are not the same. </summary>
        public static bool operator !=(AstroSingleSignOnState left, AstroSingleSignOnState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AstroSingleSignOnState"/>. </summary>
        public static implicit operator AstroSingleSignOnState(string value) => new AstroSingleSignOnState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AstroSingleSignOnState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AstroSingleSignOnState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
