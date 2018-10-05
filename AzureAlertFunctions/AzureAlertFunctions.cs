using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureAlertFunctions
{
    public static class AzureAlertFunctions
    {
        [FunctionName("AlertFunctions")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string body = await req.Content.ReadAsStringAsync();

            log.Info(body);

            return req.CreateResponse(HttpStatusCode.OK, body);
        }
    }
}
