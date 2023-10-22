using HealthCare.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthCare.Web.AspNet.Controllers
{
    public class ExameController : Controller
    {
        private IList<ExameModel> exames;

        public ExameController()
        {
            exames = new List<ExameModel>();
            exames.Add(new ExameModel("0001000", "Glicemia", "78", "05/03/2016"));
            exames.Add(new ExameModel("0001001", "Glicemia", "80", "21/05/2017"));
            exames.Add(new ExameModel("0001002", "Glicemia", "76", "18/02/2018"));
            exames.Add(new ExameModel("0002000", "Hemoglobina Glicada", "31,1", "05/03/2016"));
            exames.Add(new ExameModel("0002001", "Hemoglobina Glicada", "35", "21/05/2017"));
            exames.Add(new ExameModel("0002002", "Hemoglobina Glicada", "30,8", "18/02/2018"));
            exames.Add(new ExameModel("0003000", "Vitamina D", "36", "05/03/2016"));
            exames.Add(new ExameModel("0003001", "Vitamina D", "35", "21/05/2017"));
            exames.Add(new ExameModel("0003002", "Vitamina D", "40", "18/02/2018"));
        }

        public IActionResult Index()
        {
            return View(exames);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new ExameModel());
        }
      
    }
}
