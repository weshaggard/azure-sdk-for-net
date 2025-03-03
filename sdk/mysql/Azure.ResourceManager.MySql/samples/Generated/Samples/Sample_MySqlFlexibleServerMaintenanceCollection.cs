// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerMaintenanceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ReadAMaintenance()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Maintenance/stable/2023-12-30/examples/MaintenanceRead.json
            // this example is just showing the usage of "Maintenances_Read" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerMaintenanceResource
            MySqlFlexibleServerMaintenanceCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerMaintenances();

            // invoke the operation
            string maintenanceName = "_T9Q-TS8";
            MySqlFlexibleServerMaintenanceResource result = await collection.GetAsync(maintenanceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerMaintenanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListMaintenancesOnAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Maintenance/stable/2023-12-30/examples/MaintenancesListByServer.json
            // this example is just showing the usage of "Maintenances_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerMaintenanceResource
            MySqlFlexibleServerMaintenanceCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerMaintenances();

            // invoke the operation and iterate over the result
            await foreach (MySqlFlexibleServerMaintenanceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerMaintenanceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ReadAMaintenance()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Maintenance/stable/2023-12-30/examples/MaintenanceRead.json
            // this example is just showing the usage of "Maintenances_Read" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerMaintenanceResource
            MySqlFlexibleServerMaintenanceCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerMaintenances();

            // invoke the operation
            string maintenanceName = "_T9Q-TS8";
            bool result = await collection.ExistsAsync(maintenanceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ReadAMaintenance()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Maintenance/stable/2023-12-30/examples/MaintenanceRead.json
            // this example is just showing the usage of "Maintenances_Read" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerMaintenanceResource
            MySqlFlexibleServerMaintenanceCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerMaintenances();

            // invoke the operation
            string maintenanceName = "_T9Q-TS8";
            NullableResponse<MySqlFlexibleServerMaintenanceResource> response = await collection.GetIfExistsAsync(maintenanceName);
            MySqlFlexibleServerMaintenanceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerMaintenanceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
