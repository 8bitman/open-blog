using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostController : Controller
    {
        public IActionResult Index(int page)
        {
            return Ok(new {title = "Olá mundo!"});
        }
    }
}