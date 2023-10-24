using HealthCare.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthCare.Web.AspNet.Controllers
{
    public class PlanoSaudeController : Controller
    {
        private IList<PlanoSaudeModel> planos;

        public PlanoSaudeController()
        {
            planos = new List<PlanoSaudeModel>();
            planos.Add(new PlanoSaudeModel("0001", "Público", "SUS", "Pública"));
            planos.Add(new PlanoSaudeModel("002", "Privado", "Unimed Paulista", "Cooperativa + Obstetricia"));

        }

        public IActionResult Index()
        {
            return View(planos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new PlanoSaudeModel());
        }

        [HttpGet]
        public IActionResult Editar()
        {
            return View();
        }
    }
}
