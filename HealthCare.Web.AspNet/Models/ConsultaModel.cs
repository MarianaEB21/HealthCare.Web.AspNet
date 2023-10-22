namespace HealthCare.Web.AspNet.Models
{
    public class ConsultaModel
    {
        public ConsultaModel() { }

        public ConsultaModel(string idConsulta, string dtConsulta, string tpConsulta)
        {
            IdConsulta = idConsulta;
            DtConsulta = dtConsulta;
            TpConsulta = tpConsulta;
        }

        public string? IdConsulta { get; set; }

        public string? DtConsulta { get; set; }

        public string? TpConsulta { get; set; }

    }
}
