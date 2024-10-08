// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Advanced diagnostic consent to be updated on the support ticket. </summary>
    public readonly partial struct AdvancedDiagnosticConsent : IEquatable<AdvancedDiagnosticConsent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdvancedDiagnosticConsent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdvancedDiagnosticConsent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string YesValue = "Yes";
        private const string NoValue = "No";

        /// <summary> Yes. </summary>
        public static AdvancedDiagnosticConsent Yes { get; } = new AdvancedDiagnosticConsent(YesValue);
        /// <summary> No. </summary>
        public static AdvancedDiagnosticConsent No { get; } = new AdvancedDiagnosticConsent(NoValue);
        /// <summary> Determines if two <see cref="AdvancedDiagnosticConsent"/> values are the same. </summary>
        public static bool operator ==(AdvancedDiagnosticConsent left, AdvancedDiagnosticConsent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdvancedDiagnosticConsent"/> values are not the same. </summary>
        public static bool operator !=(AdvancedDiagnosticConsent left, AdvancedDiagnosticConsent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AdvancedDiagnosticConsent"/>. </summary>
        public static implicit operator AdvancedDiagnosticConsent(string value) => new AdvancedDiagnosticConsent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdvancedDiagnosticConsent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdvancedDiagnosticConsent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
