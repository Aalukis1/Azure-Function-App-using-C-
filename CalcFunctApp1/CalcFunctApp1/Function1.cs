using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CalcFunctApp1
{
    public static class sum
    {
        [FunctionName("sum")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x + y;

            return new OkObjectResult(result);
        }
    }
}
    /*public static class subtract
    {
        [FunctionName("subtract")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x - y;

            return new OkObjectResult(result);
        }
    }
    public static class multiply
    {
        [FunctionName("multiply")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x * y;

            return new OkObjectResult(result);
        }
    }
    public static class divide
    {
        [FunctionName("divide")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            int x = int.Parse(req.Query["x"]);
            int y = int.Parse(req.Query["y"]);
            int result = x / y;

            return new OkObjectResult(result);
        }
    }
    */

