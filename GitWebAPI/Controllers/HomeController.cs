using Microsoft.AspNetCore.Mvc;

namespace GitWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    
    public class HomeController : Controller
    {
        [HttpGet(Name = "GetStudentName")]
        public IActionResult get()
        {
            return Json( new { Name="Zackary Pantchev" });
        }
    }
}
