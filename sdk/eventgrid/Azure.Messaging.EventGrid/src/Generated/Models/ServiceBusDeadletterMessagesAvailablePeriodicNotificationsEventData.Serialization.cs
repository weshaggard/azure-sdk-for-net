// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventDataConverter))]
    public partial class ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData
    {
        internal static ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string namespaceName = default;
            string requestUri = default;
            string entityType = default;
            string queueName = default;
            string topicName = default;
            string subscriptionName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"u8))
                {
                    requestUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topicName"u8))
                {
                    topicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(
                namespaceName,
                requestUri,
                entityType,
                queueName,
                topicName,
                subscriptionName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(document.RootElement);
        }

        internal partial class ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventDataConverter : JsonConverter<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>
        {
            public override void Write(Utf8JsonWriter writer, ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(document.RootElement);
            }
        }
    }
}
