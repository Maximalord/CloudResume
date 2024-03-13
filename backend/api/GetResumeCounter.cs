using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class GetResumeCounter
    {
        [FunctionName("GetResumeCounter")]
        public static async Task<HttpResponseMessage> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [CosmosDB(
                databaseName: "AzureResume",
                collectionName: "Counter",
                ConnectionStringSetting = "AzureResumeConnectionString",
                Id = "1",
                PartitionKey = "1")] Counter counter,
            [CosmosDB(
                databaseName: "AzureResume",
                collectionName: "Counter",
                ConnectionStringSetting = "AzureResumeConnectionString",
                Id = "1",
                PartitionKey = "1")] IAsyncCollector<Counter> counterCollector,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // Increment the counter
            counter.Count++;

            // Update the counter in the database
            await counterCollector.AddAsync(counter);

            // Serialize the counter object to JSON
            string jsonToReturn = JsonConvert.SerializeObject(counter);

            // Return the response with the counter JSON
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonToReturn, Encoding.UTF8, "application/json")
            };
        }
    }
}
