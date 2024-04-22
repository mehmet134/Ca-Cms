using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.Web.Areas.App.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
