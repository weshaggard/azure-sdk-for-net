// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Possible values for DeploymentProvisioningState. </summary>
    public readonly partial struct MachineLearningDeploymentProvisioningState : IEquatable<MachineLearningDeploymentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningDeploymentProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningDeploymentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string ScalingValue = "Scaling";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static MachineLearningDeploymentProvisioningState Creating { get; } = new MachineLearningDeploymentProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static MachineLearningDeploymentProvisioningState Deleting { get; } = new MachineLearningDeploymentProvisioningState(DeletingValue);
        /// <summary> Scaling. </summary>
        public static MachineLearningDeploymentProvisioningState Scaling { get; } = new MachineLearningDeploymentProvisioningState(ScalingValue);
        /// <summary> Updating. </summary>
        public static MachineLearningDeploymentProvisioningState Updating { get; } = new MachineLearningDeploymentProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static MachineLearningDeploymentProvisioningState Succeeded { get; } = new MachineLearningDeploymentProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static MachineLearningDeploymentProvisioningState Failed { get; } = new MachineLearningDeploymentProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static MachineLearningDeploymentProvisioningState Canceled { get; } = new MachineLearningDeploymentProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="MachineLearningDeploymentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MachineLearningDeploymentProvisioningState left, MachineLearningDeploymentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningDeploymentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningDeploymentProvisioningState left, MachineLearningDeploymentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningDeploymentProvisioningState"/>. </summary>
        public static implicit operator MachineLearningDeploymentProvisioningState(string value) => new MachineLearningDeploymentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningDeploymentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningDeploymentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
