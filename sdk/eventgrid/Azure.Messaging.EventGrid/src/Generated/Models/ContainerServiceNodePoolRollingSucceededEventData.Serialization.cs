// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceNodePoolRollingSucceededEventDataConverter))]
    public partial class ContainerServiceNodePoolRollingSucceededEventData
    {
        internal static ContainerServiceNodePoolRollingSucceededEventData DeserializeContainerServiceNodePoolRollingSucceededEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nodePoolName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodePoolName"u8))
                {
                    nodePoolName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceNodePoolRollingSucceededEventData(nodePoolName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ContainerServiceNodePoolRollingSucceededEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeContainerServiceNodePoolRollingSucceededEventData(document.RootElement);
        }

        internal partial class ContainerServiceNodePoolRollingSucceededEventDataConverter : JsonConverter<ContainerServiceNodePoolRollingSucceededEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceNodePoolRollingSucceededEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ContainerServiceNodePoolRollingSucceededEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceNodePoolRollingSucceededEventData(document.RootElement);
            }
        }
    }
}
