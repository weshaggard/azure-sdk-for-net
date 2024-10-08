// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The provisioning state, which only appears in the response. </summary>
    public readonly partial struct HybridComputeProvisioningState : IEquatable<HybridComputeProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridComputeProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridComputeProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string AcceptedValue = "Accepted";
        private const string CanceledValue = "Canceled";
        private const string DeletedValue = "Deleted";

        /// <summary> Creating. </summary>
        public static HybridComputeProvisioningState Creating { get; } = new HybridComputeProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static HybridComputeProvisioningState Updating { get; } = new HybridComputeProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static HybridComputeProvisioningState Deleting { get; } = new HybridComputeProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static HybridComputeProvisioningState Succeeded { get; } = new HybridComputeProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static HybridComputeProvisioningState Failed { get; } = new HybridComputeProvisioningState(FailedValue);
        /// <summary> Accepted. </summary>
        public static HybridComputeProvisioningState Accepted { get; } = new HybridComputeProvisioningState(AcceptedValue);
        /// <summary> Canceled. </summary>
        public static HybridComputeProvisioningState Canceled { get; } = new HybridComputeProvisioningState(CanceledValue);
        /// <summary> Deleted. </summary>
        public static HybridComputeProvisioningState Deleted { get; } = new HybridComputeProvisioningState(DeletedValue);
        /// <summary> Determines if two <see cref="HybridComputeProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HybridComputeProvisioningState left, HybridComputeProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridComputeProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HybridComputeProvisioningState left, HybridComputeProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridComputeProvisioningState"/>. </summary>
        public static implicit operator HybridComputeProvisioningState(string value) => new HybridComputeProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridComputeProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridComputeProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
