using HealthCare.Web.AspNet.Models;
using HealthCare.Web.AspNet.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HealthCare.Web.AspNet.Controllers
{
    public class ConsultaController : Controller
    {
        private ConsultaRepository consultaRepository;

        private IList<ConsultaModel> consultas;

        public ConsultaController()
        {
            //consultas = new List<ConsultaModel>
            //{
                //new ConsultaModel("0000001", "27/09/2023", "Online"),
                //new ConsultaModel("0000002", "15/10/2023", "Presencial"),
                //new ConsultaModel("0000003", "10/11/2023", "Online"),
            //};

            consultaRepository = new ConsultaRepository();
        }

        public IActionResult Index()
        {
            var consultas = consultaRepository.Listar();
            return View(consultas);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ConsultaModel consulta)
        {
            Console.WriteLine("Inserindo Consulta");

            consultas.Append(new ConsultaModel(consulta.IdConsulta, consulta.DtConsulta, consulta.TpConsulta));

            return RedirectToAction("Index", "Consulta");

        }
    }
}

