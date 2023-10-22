using Microsoft.AspNetCore.Mvc;

namespace HealthCare.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
