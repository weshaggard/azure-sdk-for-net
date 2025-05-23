// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class DataflowEndpointFabricOneLake : IUtf8JsonSerializable, IJsonModel<DataflowEndpointFabricOneLake>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowEndpointFabricOneLake>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowEndpointFabricOneLake>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLake>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLake)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("authentication"u8);
            writer.WriteObjectValue(Authentication, options);
            writer.WritePropertyName("names"u8);
            writer.WriteObjectValue(Names, options);
            writer.WritePropertyName("oneLakePathType"u8);
            writer.WriteStringValue(OneLakePathType.ToString());
            writer.WritePropertyName("host"u8);
            writer.WriteStringValue(Host);
            if (Optional.IsDefined(Batching))
            {
                writer.WritePropertyName("batching"u8);
                writer.WriteObjectValue(Batching, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DataflowEndpointFabricOneLake IJsonModel<DataflowEndpointFabricOneLake>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLake>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLake)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowEndpointFabricOneLake(document.RootElement, options);
        }

        internal static DataflowEndpointFabricOneLake DeserializeDataflowEndpointFabricOneLake(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataflowEndpointFabricOneLakeAuthentication authentication = default;
            DataflowEndpointFabricOneLakeNames names = default;
            DataflowEndpointFabricPathType oneLakePathType = default;
            string host = default;
            IotOperationsBatchingConfig batching = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authentication"u8))
                {
                    authentication = DataflowEndpointFabricOneLakeAuthentication.DeserializeDataflowEndpointFabricOneLakeAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("names"u8))
                {
                    names = DataflowEndpointFabricOneLakeNames.DeserializeDataflowEndpointFabricOneLakeNames(property.Value, options);
                    continue;
                }
                if (property.NameEquals("oneLakePathType"u8))
                {
                    oneLakePathType = new DataflowEndpointFabricPathType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("batching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batching = IotOperationsBatchingConfig.DeserializeIotOperationsBatchingConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowEndpointFabricOneLake(
                authentication,
                names,
                oneLakePathType,
                host,
                batching,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowEndpointFabricOneLake>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLake>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotOperationsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLake)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowEndpointFabricOneLake IPersistableModel<DataflowEndpointFabricOneLake>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointFabricOneLake>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataflowEndpointFabricOneLake(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointFabricOneLake)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowEndpointFabricOneLake>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
