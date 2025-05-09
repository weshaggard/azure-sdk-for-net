// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Samples
{
    public partial class Sample_VMwareVmInstanceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/GetVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            VMwareVmInstanceResource result = await vMwareVmInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareVmInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/DeleteVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            await vMwareVmInstance.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/UpdateVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            VMwareVmInstancePatch patch = new VMwareVmInstancePatch
            {
                HardwareProfile = new VmInstanceHardwareProfile
                {
                    MemorySizeMB = 4196,
                    NumCpus = 4,
                },
            };
            ArmOperation<VMwareVmInstanceResource> lro = await vMwareVmInstance.UpdateAsync(WaitUntil.Completed, patch);
            VMwareVmInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareVmInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/CreateVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            VMwareVmInstanceData data = new VMwareVmInstanceData
            {
                ExtendedLocation = new ExtendedLocation
                {
                    Name = "/subscriptions/a5015e1c-867f-4533-8541-85cd470d0cfb/resourceGroups/demoRG/providers/Microsoft.ExtendedLocation/customLocations/contoso",
                },
                PlacementProfile = new PlacementProfile
                {
                    ResourcePoolId = "/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.ConnectedVMwarevSphere/ResourcePools/HRPool",
                },
                HardwareProfile = new VmInstanceHardwareProfile
                {
                    MemorySizeMB = 4196,
                    NumCpus = 4,
                },
                InfrastructureProfile = new VCenterInfrastructureProfile
                {
                    TemplateId = "/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.ConnectedVMwarevSphere/VirtualMachineTemplates/WebFrontEndTemplate",
                    VCenterId = "/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/ContosoVCenter",
                },
            };
            ArmOperation<VMwareVmInstanceResource> lro = await vMwareVmInstance.CreateOrUpdateAsync(WaitUntil.Completed, data);
            VMwareVmInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareVmInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/StopVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            StopVirtualMachineContent content = new StopVirtualMachineContent
            {
                SkipShutdown = true,
            };
            await vMwareVmInstance.StopAsync(WaitUntil.Completed, content: content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_StartVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/StartVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            await vMwareVmInstance.StartAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Restart_RestartVirtualMachine()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/RestartVirtualMachineInstance.json
            // this example is just showing the usage of "VirtualMachineInstances_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareVmInstanceResource created on azure
            // for more information of creating VMwareVmInstanceResource, please refer to the document of VMwareVmInstanceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier vMwareVmInstanceResourceId = VMwareVmInstanceResource.CreateResourceIdentifier(resourceUri);
            VMwareVmInstanceResource vMwareVmInstance = client.GetVMwareVmInstanceResource(vMwareVmInstanceResourceId);

            // invoke the operation
            await vMwareVmInstance.RestartAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
