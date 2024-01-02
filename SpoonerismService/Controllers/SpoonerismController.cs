using Microsoft.AspNetCore.Mvc;
using SpoonerismMicroservice.Services;

namespace SpoonerismMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpoonerismController : ControllerBase
    {
        private readonly ILogger<SpoonerismController> _logger;

        public SpoonerismController(ILogger<SpoonerismController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSpoonerizedResult")]
        public ActionResult<string> Get(string text)
        {
            SpoonerismService spoonerismService = new SpoonerismService();

            return spoonerismService.ApplySpoonerism(text);
        }

       
    }
}