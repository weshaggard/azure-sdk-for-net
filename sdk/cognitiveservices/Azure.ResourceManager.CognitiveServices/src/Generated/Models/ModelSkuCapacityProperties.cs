// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account ModelSkuCapacity. </summary>
    public partial class ModelSkuCapacityProperties
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

        /// <summary> Initializes a new instance of <see cref="ModelSkuCapacityProperties"/>. </summary>
        public ModelSkuCapacityProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ModelSkuCapacityProperties"/>. </summary>
        /// <param name="model"> Properties of Cognitive Services account deployment model. </param>
        /// <param name="skuName"></param>
        /// <param name="availableCapacity"> The available capacity for deployment with this model and sku. </param>
        /// <param name="availableFinetuneCapacity"> The available capacity for deployment with a fine-tune version of this model and sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelSkuCapacityProperties(CognitiveServicesAccountDeploymentModel model, string skuName, float? availableCapacity, float? availableFinetuneCapacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            SkuName = skuName;
            AvailableCapacity = availableCapacity;
            AvailableFinetuneCapacity = availableFinetuneCapacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties of Cognitive Services account deployment model. </summary>
        [WirePath("model")]
        public CognitiveServicesAccountDeploymentModel Model { get; set; }
        /// <summary> Gets or sets the sku name. </summary>
        [WirePath("skuName")]
        public string SkuName { get; set; }
        /// <summary> The available capacity for deployment with this model and sku. </summary>
        [WirePath("availableCapacity")]
        public float? AvailableCapacity { get; set; }
        /// <summary> The available capacity for deployment with a fine-tune version of this model and sku. </summary>
        [WirePath("availableFinetuneCapacity")]
        public float? AvailableFinetuneCapacity { get; set; }
    }
}
