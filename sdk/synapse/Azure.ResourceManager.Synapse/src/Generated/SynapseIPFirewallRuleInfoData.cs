// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseIPFirewallRuleInfo data model.
    /// IP firewall rule
    /// </summary>
    public partial class SynapseIPFirewallRuleInfoData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SynapseIPFirewallRuleInfoData"/>. </summary>
        public SynapseIPFirewallRuleInfoData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIPFirewallRuleInfoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="endIPAddress"> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="startIPAddress"> The start IP address of the firewall rule. Must be IPv4 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseIPFirewallRuleInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress endIPAddress, SynapseProvisioningState? provisioningState, IPAddress startIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            EndIPAddress = endIPAddress;
            ProvisioningState = provisioningState;
            StartIPAddress = startIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. </summary>
        public IPAddress EndIPAddress { get; set; }
        /// <summary> Resource provisioning state. </summary>
        public SynapseProvisioningState? ProvisioningState { get; }
        /// <summary> The start IP address of the firewall rule. Must be IPv4 format. </summary>
        public IPAddress StartIPAddress { get; set; }
    }
}
