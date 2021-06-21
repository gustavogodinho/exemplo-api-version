using Microsoft.AspNetCore.Mvc;

namespace api_version.Controllers.V2
{
    [ApiController]
    [Route("prv/v{version:apiVersion}/[controller]")] // Support path versioning
    [ApiVersion("2.0")]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public string Get() => "v2.0";


        [HttpPost("TesteGustavo")]
        public IActionResult Teste(string teste)
        {
            if (teste == "SIM")
                return BadRequest("Teste Retorno BadRequest");

            return Ok();
        }


    }
}
