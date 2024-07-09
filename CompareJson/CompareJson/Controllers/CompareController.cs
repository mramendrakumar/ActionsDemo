using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;

namespace CompareJson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompareController : ControllerBase
    {
       

        private readonly ILogger<CompareController> _logger;

        public CompareController(ILogger<CompareController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "comparejson")]
        public IActionResult Get()
        {
            // load Json1
            using (StreamReader r = new StreamReader("~/mydata/userData.json"))
            {
                string firstfile = r.ReadToEnd();
            }

            // load Json1

            var result = new Dictionary<string, string>();
            var plainJsonObject = JToken.Parse(PlainJsonString);
            var secondJsonObject = JToken.Parse(SecondPlainJsonString);
            var nestedJsonObject = JToken.Parse(NestedJsonString);
            var isPlainAndNestedObjectEqual = JToken.DeepEquals(secondJsonObject, nestedJsonObject);
        }
    }
}