using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.eventhub
{
    public class Producer
    {

        public static async Task Main()
        {
            // Event Hub namespace and event hub name
            string eventHubNamespace = "manish-eventhub-namespace";
            string eventHubName = "manish-eventhub";

            // Connection string for the Event Hub
            string connectionString = $"Endpoint=sb://manish-eventhub-namespace.servicebus.windows.net/;SharedAccessKeyName=policy;SharedAccessKey=N8Uz6LwIMjnpR8fKp+VPK7SP7hulhXak7+AEhEt+Ino=;EntityPath=manish-eventhub";

            // Create an Event Hub producer client
            await using (var producerClient = new EventHubProducerClient(connectionString, eventHubName))
            {
                // Create a batch of events
                using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();

                // Add a message to the batch
                var eventData = new EventData(Encoding.UTF8.GetBytes("Hello, Event Hub from manish!"));
                eventBatch.TryAdd(eventData);

                // Send the batch to the Event Hub
                await producerClient.SendAsync(eventBatch);
                Console.WriteLine("Message sent to Event Hub.");
            }
        }
    }
}
