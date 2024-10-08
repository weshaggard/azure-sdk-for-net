// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Compliance state of the cluster object. </summary>
    public readonly partial struct KubernetesFluxComplianceState : IEquatable<KubernetesFluxComplianceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesFluxComplianceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesFluxComplianceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompliantValue = "Compliant";
        private const string NonCompliantValue = "Non-Compliant";
        private const string PendingValue = "Pending";
        private const string SuspendedValue = "Suspended";
        private const string UnknownValue = "Unknown";

        /// <summary> Compliant. </summary>
        public static KubernetesFluxComplianceState Compliant { get; } = new KubernetesFluxComplianceState(CompliantValue);
        /// <summary> Non-Compliant. </summary>
        public static KubernetesFluxComplianceState NonCompliant { get; } = new KubernetesFluxComplianceState(NonCompliantValue);
        /// <summary> Pending. </summary>
        public static KubernetesFluxComplianceState Pending { get; } = new KubernetesFluxComplianceState(PendingValue);
        /// <summary> Suspended. </summary>
        public static KubernetesFluxComplianceState Suspended { get; } = new KubernetesFluxComplianceState(SuspendedValue);
        /// <summary> Unknown. </summary>
        public static KubernetesFluxComplianceState Unknown { get; } = new KubernetesFluxComplianceState(UnknownValue);
        /// <summary> Determines if two <see cref="KubernetesFluxComplianceState"/> values are the same. </summary>
        public static bool operator ==(KubernetesFluxComplianceState left, KubernetesFluxComplianceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesFluxComplianceState"/> values are not the same. </summary>
        public static bool operator !=(KubernetesFluxComplianceState left, KubernetesFluxComplianceState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KubernetesFluxComplianceState"/>. </summary>
        public static implicit operator KubernetesFluxComplianceState(string value) => new KubernetesFluxComplianceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesFluxComplianceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesFluxComplianceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
