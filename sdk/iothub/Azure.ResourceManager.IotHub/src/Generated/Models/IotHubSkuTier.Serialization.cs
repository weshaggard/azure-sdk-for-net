// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    internal static partial class IotHubSkuTierExtensions
    {
        public static string ToSerialString(this IotHubSkuTier value) => value switch
        {
            IotHubSkuTier.Free => "Free",
            IotHubSkuTier.Standard => "Standard",
            IotHubSkuTier.Basic => "Basic",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IotHubSkuTier value.")
        };

        public static IotHubSkuTier ToIotHubSkuTier(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Free")) return IotHubSkuTier.Free;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard")) return IotHubSkuTier.Standard;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Basic")) return IotHubSkuTier.Basic;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IotHubSkuTier value.");
        }
    }
}
