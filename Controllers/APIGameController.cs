using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeverGame106.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIGameController : ControllerBase
    { 
        [HttpGet]
        public IActionResult Get()
        {
            Game106Model game106 = new Game106Model
            {
                CourseName = "Back-End Game Programming",
                CourseCode = "GAM106",
                Name = "Dinh Van Binh",
                StudentCode = "PD10121",
                Class = "GAM19301"
            };
            int status = 1;
            string message = "Get data sucess";
            var data = new { status, message, game106 };
            return new JsonResult(game106);
        }
    }
}