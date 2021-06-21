using Microsoft.AspNetCore.Mvc;

namespace api_version.Controllers.V1
{
    [ApiController]
    [Route("prv/v{version:apiVersion}/[controller]")] // Support path versioning
    [ApiVersion("1.0", Deprecated = true)]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public string Get() => "v1.0";

    }
}
