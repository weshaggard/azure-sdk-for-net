// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the additional replica set information. </summary>
    public partial class AdditionalReplicaSet
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AdditionalReplicaSet"/>. </summary>
        public AdditionalReplicaSet()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalReplicaSet"/>. </summary>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to create the direct drive replicas. </param>
        /// <param name="regionalReplicaCount"> The number of direct drive replicas of the Image Version to be created.This Property is updatable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdditionalReplicaSet(ImageStorageAccountType? storageAccountType, int? regionalReplicaCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccountType = storageAccountType;
            RegionalReplicaCount = regionalReplicaCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the storage account type to be used to create the direct drive replicas. </summary>
        public ImageStorageAccountType? StorageAccountType { get; set; }
        /// <summary> The number of direct drive replicas of the Image Version to be created.This Property is updatable. </summary>
        public int? RegionalReplicaCount { get; set; }
    }
}
