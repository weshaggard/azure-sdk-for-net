// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingAssociatedTenantResource"/> and their operations.
    /// Each <see cref="BillingAssociatedTenantResource"/> in the collection will belong to the same instance of <see cref="BillingAccountResource"/>.
    /// To get a <see cref="BillingAssociatedTenantCollection"/> instance call the GetBillingAssociatedTenants method from an instance of <see cref="BillingAccountResource"/>.
    /// </summary>
    public partial class BillingAssociatedTenantCollection : ArmCollection, IEnumerable<BillingAssociatedTenantResource>, IAsyncEnumerable<BillingAssociatedTenantResource>
    {
        private readonly ClientDiagnostics _billingAssociatedTenantAssociatedTenantsClientDiagnostics;
        private readonly AssociatedTenantsRestOperations _billingAssociatedTenantAssociatedTenantsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingAssociatedTenantCollection"/> class for mocking. </summary>
        protected BillingAssociatedTenantCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAssociatedTenantCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingAssociatedTenantCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingAssociatedTenantAssociatedTenantsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingAssociatedTenantResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingAssociatedTenantResource.ResourceType, out string billingAssociatedTenantAssociatedTenantsApiVersion);
            _billingAssociatedTenantAssociatedTenantsRestClient = new AssociatedTenantsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingAssociatedTenantAssociatedTenantsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an associated tenant for the billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="data"> An associated tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BillingAssociatedTenantResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string associatedTenantName, BillingAssociatedTenantData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _billingAssociatedTenantAssociatedTenantsRestClient.CreateOrUpdateAsync(Id.Name, associatedTenantName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation<BillingAssociatedTenantResource>(new BillingAssociatedTenantOperationSource(Client), _billingAssociatedTenantAssociatedTenantsClientDiagnostics, Pipeline, _billingAssociatedTenantAssociatedTenantsRestClient.CreateCreateOrUpdateRequest(Id.Name, associatedTenantName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an associated tenant for the billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="data"> An associated tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BillingAssociatedTenantResource> CreateOrUpdate(WaitUntil waitUntil, string associatedTenantName, BillingAssociatedTenantData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _billingAssociatedTenantAssociatedTenantsRestClient.CreateOrUpdate(Id.Name, associatedTenantName, data, cancellationToken);
                var operation = new BillingArmOperation<BillingAssociatedTenantResource>(new BillingAssociatedTenantOperationSource(Client), _billingAssociatedTenantAssociatedTenantsClientDiagnostics, Pipeline, _billingAssociatedTenantAssociatedTenantsRestClient.CreateCreateOrUpdateRequest(Id.Name, associatedTenantName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an associated tenant by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> is null. </exception>
        public virtual async Task<Response<BillingAssociatedTenantResource>> GetAsync(string associatedTenantName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingAssociatedTenantAssociatedTenantsRestClient.GetAsync(Id.Name, associatedTenantName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAssociatedTenantResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an associated tenant by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> is null. </exception>
        public virtual Response<BillingAssociatedTenantResource> Get(string associatedTenantName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.Get");
            scope.Start();
            try
            {
                var response = _billingAssociatedTenantAssociatedTenantsRestClient.Get(Id.Name, associatedTenantName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAssociatedTenantResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the associated tenants that can collaborate with the billing account on commerce activities like viewing and downloading invoices, managing payments, making purchases, and managing or provisioning licenses.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingAssociatedTenantResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingAssociatedTenantResource> GetAllAsync(BillingAssociatedTenantCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new BillingAssociatedTenantCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingAssociatedTenantAssociatedTenantsRestClient.CreateListByBillingAccountRequest(Id.Name, options.IncludeRevoked, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingAssociatedTenantAssociatedTenantsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, options.IncludeRevoked, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingAssociatedTenantResource(Client, BillingAssociatedTenantData.DeserializeBillingAssociatedTenantData(e)), _billingAssociatedTenantAssociatedTenantsClientDiagnostics, Pipeline, "BillingAssociatedTenantCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the associated tenants that can collaborate with the billing account on commerce activities like viewing and downloading invoices, managing payments, making purchases, and managing or provisioning licenses.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingAssociatedTenantResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingAssociatedTenantResource> GetAll(BillingAssociatedTenantCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new BillingAssociatedTenantCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingAssociatedTenantAssociatedTenantsRestClient.CreateListByBillingAccountRequest(Id.Name, options.IncludeRevoked, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingAssociatedTenantAssociatedTenantsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, options.IncludeRevoked, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingAssociatedTenantResource(Client, BillingAssociatedTenantData.DeserializeBillingAssociatedTenantData(e)), _billingAssociatedTenantAssociatedTenantsClientDiagnostics, Pipeline, "BillingAssociatedTenantCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string associatedTenantName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingAssociatedTenantAssociatedTenantsRestClient.GetAsync(Id.Name, associatedTenantName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> is null. </exception>
        public virtual Response<bool> Exists(string associatedTenantName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingAssociatedTenantAssociatedTenantsRestClient.Get(Id.Name, associatedTenantName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingAssociatedTenantResource>> GetIfExistsAsync(string associatedTenantName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingAssociatedTenantAssociatedTenantsRestClient.GetAsync(Id.Name, associatedTenantName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingAssociatedTenantResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAssociatedTenantResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/associatedTenants/{associatedTenantName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociatedTenants_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAssociatedTenantResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associatedTenantName"> The ID that uniquely identifies a tenant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associatedTenantName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associatedTenantName"/> is null. </exception>
        public virtual NullableResponse<BillingAssociatedTenantResource> GetIfExists(string associatedTenantName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associatedTenantName, nameof(associatedTenantName));

            using var scope = _billingAssociatedTenantAssociatedTenantsClientDiagnostics.CreateScope("BillingAssociatedTenantCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingAssociatedTenantAssociatedTenantsRestClient.Get(Id.Name, associatedTenantName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingAssociatedTenantResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAssociatedTenantResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingAssociatedTenantResource> IEnumerable<BillingAssociatedTenantResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<BillingAssociatedTenantResource> IAsyncEnumerable<BillingAssociatedTenantResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
