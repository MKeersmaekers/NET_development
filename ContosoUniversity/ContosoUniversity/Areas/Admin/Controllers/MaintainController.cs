using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MaintainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
