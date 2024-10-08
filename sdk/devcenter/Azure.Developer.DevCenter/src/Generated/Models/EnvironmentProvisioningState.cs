// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> The provisioning state of the environment. </summary>
    public readonly partial struct EnvironmentProvisioningState : IEquatable<EnvironmentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnvironmentProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnvironmentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string PreparingValue = "Preparing";
        private const string RunningValue = "Running";
        private const string SyncingValue = "Syncing";
        private const string MovingResourcesValue = "MovingResources";
        private const string TransientFailureValue = "TransientFailure";
        private const string StorageProvisioningFailedValue = "StorageProvisioningFailed";

        /// <summary> The environment was successfully provisioned. </summary>
        public static EnvironmentProvisioningState Succeeded { get; } = new EnvironmentProvisioningState(SucceededValue);
        /// <summary> The environment failed to provision. </summary>
        public static EnvironmentProvisioningState Failed { get; } = new EnvironmentProvisioningState(FailedValue);
        /// <summary> The environment provisioning was canceled. </summary>
        public static EnvironmentProvisioningState Canceled { get; } = new EnvironmentProvisioningState(CanceledValue);
        /// <summary> The environment is creating. </summary>
        public static EnvironmentProvisioningState Creating { get; } = new EnvironmentProvisioningState(CreatingValue);
        /// <summary> The environment was accepted. </summary>
        public static EnvironmentProvisioningState Accepted { get; } = new EnvironmentProvisioningState(AcceptedValue);
        /// <summary> The environment is deleting. </summary>
        public static EnvironmentProvisioningState Deleting { get; } = new EnvironmentProvisioningState(DeletingValue);
        /// <summary> The environment is updating. </summary>
        public static EnvironmentProvisioningState Updating { get; } = new EnvironmentProvisioningState(UpdatingValue);
        /// <summary> The environment is preparing. </summary>
        public static EnvironmentProvisioningState Preparing { get; } = new EnvironmentProvisioningState(PreparingValue);
        /// <summary> The environment is running. </summary>
        public static EnvironmentProvisioningState Running { get; } = new EnvironmentProvisioningState(RunningValue);
        /// <summary> The environment is Syncing. </summary>
        public static EnvironmentProvisioningState Syncing { get; } = new EnvironmentProvisioningState(SyncingValue);
        /// <summary> The environment is moving resources. </summary>
        public static EnvironmentProvisioningState MovingResources { get; } = new EnvironmentProvisioningState(MovingResourcesValue);
        /// <summary> The environment has a transient failure. </summary>
        public static EnvironmentProvisioningState TransientFailure { get; } = new EnvironmentProvisioningState(TransientFailureValue);
        /// <summary> The environment storage provisioning failed. </summary>
        public static EnvironmentProvisioningState StorageProvisioningFailed { get; } = new EnvironmentProvisioningState(StorageProvisioningFailedValue);
        /// <summary> Determines if two <see cref="EnvironmentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EnvironmentProvisioningState left, EnvironmentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnvironmentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EnvironmentProvisioningState left, EnvironmentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EnvironmentProvisioningState"/>. </summary>
        public static implicit operator EnvironmentProvisioningState(string value) => new EnvironmentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnvironmentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnvironmentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
