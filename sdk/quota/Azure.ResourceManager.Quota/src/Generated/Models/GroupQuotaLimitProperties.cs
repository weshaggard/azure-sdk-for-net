// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Group Quota properties for the specified resource. </summary>
    public partial class GroupQuotaLimitProperties : GroupQuotaDetails
    {
        /// <summary> Initializes a new instance of <see cref="GroupQuotaLimitProperties"/>. </summary>
        public GroupQuotaLimitProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GroupQuotaLimitProperties"/>. </summary>
        /// <param name="resourceName"> The resource name, such as SKU name. </param>
        /// <param name="limit"> The current Group Quota Limit at the parentId level. </param>
        /// <param name="comment"> Any comment related to quota request. </param>
        /// <param name="unit"> The usages units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="availableLimit"> The available Group Quota Limit at the MG level. This Group quota can be allocated to subscription(s). </param>
        /// <param name="allocatedToSubscriptions"> Quota allocated to subscriptions. </param>
        /// <param name="value"> Resource name. </param>
        /// <param name="localizedValue"> Resource display name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GroupQuotaLimitProperties(string resourceName, long? limit, string comment, string unit, long? availableLimit, AllocatedQuotaToSubscriptionList allocatedToSubscriptions, string value, string localizedValue, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceName, limit, comment, unit, availableLimit, allocatedToSubscriptions, value, localizedValue, serializedAdditionalRawData)
        {
        }
    }
}
