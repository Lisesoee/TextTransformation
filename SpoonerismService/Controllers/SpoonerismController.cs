using Microsoft.AspNetCore.Mvc;
using SpoonerismMicroservice.Services;

namespace SpoonerismMicroservice.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("[controller]/[action]")]
    public class SpoonerismController : ControllerBase
    {
        private readonly ILogger<SpoonerismController> _logger;

        public SpoonerismController(ILogger<SpoonerismController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetSpoonerizedResult")]
        [HttpGet]
        [ActionName("GetSpoonerizedResult")]
        public string Get(string text)
        {
            SpoonerismService spoonerismService = new SpoonerismService();
            string spoonerizedText = spoonerismService.ApplySpoonerism(text);
            Console.WriteLine("Spoonerized Result = " + spoonerizedText);

            return spoonerizedText;
        }       
    }
}