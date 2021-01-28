using Microsoft.AspNetCore.Mvc;

namespace e.moiroServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
