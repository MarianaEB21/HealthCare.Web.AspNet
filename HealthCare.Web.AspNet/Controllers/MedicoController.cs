using Microsoft.AspNetCore.Mvc;

namespace HealthCare.Web.AspNet.Controllers
{
    public class MedicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
