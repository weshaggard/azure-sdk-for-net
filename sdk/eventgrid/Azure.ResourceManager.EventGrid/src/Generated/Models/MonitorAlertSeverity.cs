// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// The severity that will be attached to every Alert fired through this event subscription.
    /// This field must be provided.
    /// </summary>
    public readonly partial struct MonitorAlertSeverity : IEquatable<MonitorAlertSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorAlertSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorAlertSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Sev0Value = "Sev0";
        private const string Sev1Value = "Sev1";
        private const string Sev2Value = "Sev2";
        private const string Sev3Value = "Sev3";
        private const string Sev4Value = "Sev4";

        /// <summary> Sev0. </summary>
        public static MonitorAlertSeverity Sev0 { get; } = new MonitorAlertSeverity(Sev0Value);
        /// <summary> Sev1. </summary>
        public static MonitorAlertSeverity Sev1 { get; } = new MonitorAlertSeverity(Sev1Value);
        /// <summary> Sev2. </summary>
        public static MonitorAlertSeverity Sev2 { get; } = new MonitorAlertSeverity(Sev2Value);
        /// <summary> Sev3. </summary>
        public static MonitorAlertSeverity Sev3 { get; } = new MonitorAlertSeverity(Sev3Value);
        /// <summary> Sev4. </summary>
        public static MonitorAlertSeverity Sev4 { get; } = new MonitorAlertSeverity(Sev4Value);
        /// <summary> Determines if two <see cref="MonitorAlertSeverity"/> values are the same. </summary>
        public static bool operator ==(MonitorAlertSeverity left, MonitorAlertSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorAlertSeverity"/> values are not the same. </summary>
        public static bool operator !=(MonitorAlertSeverity left, MonitorAlertSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MonitorAlertSeverity"/>. </summary>
        public static implicit operator MonitorAlertSeverity(string value) => new MonitorAlertSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorAlertSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorAlertSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
