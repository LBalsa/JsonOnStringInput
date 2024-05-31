using Microsoft.AspNetCore.Mvc;

namespace JsonOnStringInputNotWorking.Controllers
{
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpPost]
        [Route("notworking")]
        public ActionResult NotWorking([FromForm] Request request)
        {
            return !string.IsNullOrEmpty(request.Data) ? Ok(request.Data) : BadRequest();
        }
    }

    public class Request
    {
        public string? Data { get; init; }
        public IFormFile? Template { get; init; }
    }
}
