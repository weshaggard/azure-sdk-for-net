// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The AggregationFunctionType. </summary>
    public readonly partial struct AggregationFunctionType : IEquatable<AggregationFunctionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AggregationFunctionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AggregationFunctionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvgValue = "avg";
        private const string MinValue = "min";
        private const string MaxValue = "max";
        private const string StdevValue = "stdev";
        private const string SumValue = "sum";

        /// <summary> avg. </summary>
        public static AggregationFunctionType Avg { get; } = new AggregationFunctionType(AvgValue);
        /// <summary> min. </summary>
        public static AggregationFunctionType Min { get; } = new AggregationFunctionType(MinValue);
        /// <summary> max. </summary>
        public static AggregationFunctionType Max { get; } = new AggregationFunctionType(MaxValue);
        /// <summary> stdev. </summary>
        public static AggregationFunctionType Stdev { get; } = new AggregationFunctionType(StdevValue);
        /// <summary> sum. </summary>
        public static AggregationFunctionType Sum { get; } = new AggregationFunctionType(SumValue);
        /// <summary> Determines if two <see cref="AggregationFunctionType"/> values are the same. </summary>
        public static bool operator ==(AggregationFunctionType left, AggregationFunctionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AggregationFunctionType"/> values are not the same. </summary>
        public static bool operator !=(AggregationFunctionType left, AggregationFunctionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AggregationFunctionType"/>. </summary>
        public static implicit operator AggregationFunctionType(string value) => new AggregationFunctionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AggregationFunctionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AggregationFunctionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
