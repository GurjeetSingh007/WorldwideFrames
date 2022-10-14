using Microsoft.AspNetCore.Mvc;

namespace WorldwideFrames.Controllers
{
    public class FrameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
