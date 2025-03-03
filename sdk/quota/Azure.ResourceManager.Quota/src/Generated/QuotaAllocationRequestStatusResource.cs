// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a QuotaAllocationRequestStatus along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="QuotaAllocationRequestStatusResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetQuotaAllocationRequestStatusResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagementGroupResource"/> using the GetQuotaAllocationRequestStatus method.
    /// </summary>
    public partial class QuotaAllocationRequestStatusResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="QuotaAllocationRequestStatusResource"/> instance. </summary>
        /// <param name="managementGroupId"> The managementGroupId. </param>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="groupQuotaName"> The groupQuotaName. </param>
        /// <param name="resourceProviderName"> The resourceProviderName. </param>
        /// <param name="allocationId"> The allocationId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string subscriptionId, string groupQuotaName, string resourceProviderName, string allocationId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics;
        private readonly GroupQuotaSubscriptionAllocationRequestRestOperations _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient;
        private readonly QuotaAllocationRequestStatusData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/groupQuotas/resourceProviders/quotaAllocationRequests";

        /// <summary> Initializes a new instance of the <see cref="QuotaAllocationRequestStatusResource"/> class for mocking. </summary>
        protected QuotaAllocationRequestStatusResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaAllocationRequestStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal QuotaAllocationRequestStatusResource(ArmClient client, QuotaAllocationRequestStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaAllocationRequestStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal QuotaAllocationRequestStatusResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestApiVersion);
            _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient = new GroupQuotaSubscriptionAllocationRequestRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual QuotaAllocationRequestStatusData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the quota allocation request status for the subscriptionId by allocationId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QuotaAllocationRequestStatusResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusResource.Get");
            scope.Start();
            try
            {
                var response = await _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.GetAsync(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaAllocationRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the quota allocation request status for the subscriptionId by allocationId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QuotaAllocationRequestStatusResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusResource.Get");
            scope.Start();
            try
            {
                var response = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.Get(Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaAllocationRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
