// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyCertificateAuthority : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultSecretId))
            {
                writer.WritePropertyName("keyVaultSecretId");
                writer.WriteStringValue(KeyVaultSecretId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FirewallPolicyCertificateAuthority DeserializeFirewallPolicyCertificateAuthority(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> keyVaultSecretId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("keyVaultSecretId"))
                        {
                            keyVaultSecretId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FirewallPolicyCertificateAuthority(name.Value, keyVaultSecretId.Value);
        }
    }
}
