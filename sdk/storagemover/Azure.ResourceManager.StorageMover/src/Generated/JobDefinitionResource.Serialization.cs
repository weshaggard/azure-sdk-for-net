// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.StorageMover
{
    public partial class JobDefinitionResource : IJsonModel<JobDefinitionData>
    {
        private static JobDefinitionData s_dataDeserializationInstance;
        private static JobDefinitionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<JobDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<JobDefinitionData>)Data).Write(writer, options);

        JobDefinitionData IJsonModel<JobDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<JobDefinitionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<JobDefinitionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<JobDefinitionData>(Data, options, AzureResourceManagerStorageMoverContext.Default);

        JobDefinitionData IPersistableModel<JobDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<JobDefinitionData>(data, options, AzureResourceManagerStorageMoverContext.Default);

        string IPersistableModel<JobDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<JobDefinitionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
