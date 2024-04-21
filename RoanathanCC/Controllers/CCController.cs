using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoanathanCC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CCController : ControllerBase
    {
        //post listener for webhook response from ronathan AI Agent 
        [HttpPost("ronathanagentfilecrawler")]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            
            Console.WriteLine("ronathanagentFileCrawler: " + value);

            return Ok();
        }   

    }
}
