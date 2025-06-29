# Release History

## 1.12.0-beta.1 (Unreleased)

### Features Added

- Added support for [managed identity as a federated identity credential](https://learn.microsoft.com/entra/workload-id/workload-identity-federation-config-app-trust-managed-identity?tabs=microsoft-entra-admin-center%2Cdotnet#azure-identity-client-libraries) in the client factory by specifying configuration item `credential` as "managedidentityasfederatedidentity" and providing the following named configuration items:

  - `tenantId` : The tenant where the target resource was created
  - `clientId` : The client identifier for the application, which must be granted access on the target resource
  - One of [`managedIdentityClientId`, `objectId`, `resourceId`] : The user-assigned managed identity which you configured as a Federated Identity Credential (FIC)
  - `azureCloud`: One of the following Azure cloud environments:
    - `public` for Entra ID Global cloud
    - `usgov` for Entra ID US Government
    - `china` for Entra ID China operated by 21Vianet

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.11.0 (2025-03-15)

### Features Added

- Added support for [AzurePipelinesCredential](https://learn.microsoft.com/dotnet/api/azure.identity.azurepipelinescredential?view=azure-dotnet) in the client factory by specifying configuration item `credential` as "azurepipelines" and providing each credential parameter as a named configuration item.

### Bugs Fixed

- Fixed an issue when creating clients from configuration using the ASP.NET Core integration testing library, `Microsoft.AspNetCore.Mvc.Testing`.  Due to a difference in how an section value is represented, logic was interpreting a setting with a child object as an empty connection string value.  The child object is now properly parsed and applied for client construction.  ([#48368](https://github.com/Azure/azure-sdk-for-net/issues/48368))

## 1.10.0 (2025-02-11)

### Other Changes
- Updated dependencies to ensure they are up-to-date with the latest targets and trimming from built-in dependencies.

## 1.9.0 (2024-11-26)

### Other Changes

- Updated dependency `Microsoft.Extensions.DependencyInjection.Abstractions` to version `8.0.2`
- Updated dependency `Microsoft.Bcl.AsyncInterfaces` to version `8.0.0`

## 1.8.0 (2024-11-05)

### Features Added

- Added support for constructing a `ManagedIdentityCredential` from config by setting the `managedIdentityObjectId` key.

### Other Changes

- Updated dependency `Azure.Identity` to version `1.13.1`.

## 1.7.6 (2024-10-04)

### Other Changes

- Improved the efficiency of `AzureEventSourceLogForwarder` by eliminating message formatting. ([#46202](https://github.com/Azure/azure-sdk-for-net/pull/46202))

## 1.7.5 (2024-08-15)

### Other Changes

- Updated dependency `Azure.Core` to version `1.42.0`.

## 1.7.4 (2024-06-13)

### Other Changes

- Updated dependency `Azure.Identity` to version `1.11.4`.

## 1.7.3 (2024-04-16)

### Other Changes

- Updated dependency `Azure.Identity` to version `1.11.0`.

## 1.7.2 (2024-02-12)

### Bugs Fixed

- Fix several issues related to ThreadPool starvation for synchronous scenarios

## 1.7.1 (2023-10-27)

### Other Changes

- Updated dependency `Azure.Identity` to version `1.10.3`.

## 1.7.0 (2023-08-08)

### Features Added

- Added support for creating `WorkloadIdentityCredential` objects from the configuration using the `"credential": "workloadidentity"`. Users must provide values for the `tenantId`, `clientId`, and newly added `tokenFilePath` keys in the configuration, or they must set the environment variables `AZURE_TENANT_ID`, `AZURE_CLIENT_ID`, and `AZURE_FEDERATED_TOKEN_FILE`.

### Other Changes

- Updated dependency `Azure.Identity` to version `1.9.0`.

## 1.6.3 (2023-03-10)

### Other Changes

- Upgraded dependent `Azure.Core` to `1.30.0`.

## 1.6.2 (2023-03-07)

### Bugs Fixed

- Added support for clients to be disposed via `IDisposable` or `IAsyncDisposable` when the service factory is disposed.
- Changed tracking for client initialization to ensure that behavior is correct for value types registered as clients.

## 1.6.0 (2022-10-12)

### Features Added

- Support passing a semi-colon delimited list of additional tenants via the `additionallyAllowedTenants` config. See the [Azure.Identity Breaking Changes log](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/identity/Azure.Identity/BREAKING_CHANGES.md#170) for more information about this setting.

### Bugs Fixed

- The `tenantId`, `clientId`, `managedIdentityResourceId`, and the newly added `additionallyAllowedTenants` will be passed onto the created `DefaultAzureCredential` if no `clientSecret` or `clientCertificate` is provided. Previously, these values would be ignored when falling back to the `DefaultAzureCredential` or the user-provided credential specified via  `AzureClientFactoryBuilder.UseCredential`.

## 1.5.0 (2022-08-24)

### Bugs Fixed

- Hiding the new `AddAzureClientsCore` overload from IntelliSense, as its usage is not intuitive.

## 1.4.0 (2022-08-11)

### Features Added

- Added the `AddAzureClientsCore` method overload that has a parameter to allow enabling log
  forwarding to `ILogger`.

## 1.3.0 (2022-07-12)

### Features Added

- Added support for constructing a `ManagedIdentityCredential` from config by setting the `managedIdentityResourceId` key.

## 1.2.0 (2022-05-10)

### Other Changes

- Added support for GUID constructor parameters to be parsed directly from configuration.

## 1.1.1 (2021-09-07)

### Bugs Fixed

- Improved the diagnostic message when a constructor can't be selected.
- The issue where aggressive parameter validation caused constructor not to be selected.

## 1.1.0 (2021-06-09)

### Changes

#### Breaking changes

- The factory parameters to `AddClient` method were reordered.

## 1.1.0-beta.3 (2021-05-11)

### Changes

#### New Features

- The `AddClient` method that allows registering any Azure SDK client with a custom factory function.

## 1.1.0-beta.2 (2021-02-09)

### Added

- The ability to use `ManagedIdentityCredential` from the configuration using the `"credential": "managedidentity"`

## 1.1.0-beta.1 (2020-11-10)

### Added

- The `AzureComponentFactory` class that allows creating `TokenCredential`, `ClientOptions` and client instances from configuration.
- The `AzureEventSourceLogForwarder` class that allows manual control over the log forwarding.
- The `AddAzureClientsCore` extension method.

## 1.0.0

- Updated Azure.Identity dependency version

## 1.0.0-preview.3

- Updated Azure.Identity dependency version

## 1.0.0-preview.2

- Minor bug fixes and code improvements.

## 1.0.0-preview.1

- Added TokenCredential support.
- Added client version support.
- Added default client support.
