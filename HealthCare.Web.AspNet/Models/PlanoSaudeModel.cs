namespace HealthCare.Web.AspNet.Models
{
    public class PlanoSaudeModel
    {
        public PlanoSaudeModel()
        {
        }

        public PlanoSaudeModel(String idPlano, String tpPlano, String nmPlano, String tpCobertura)
        {
            this.IdPlano = idPlano;
            this.TpPlano = tpPlano;
            this.NmPlano = nmPlano;
            this.TpCobertura = tpCobertura;

        }

        public String? IdPlano { get; set; }

        public String? TpPlano { get; set; }

        public String? NmPlano { get; set; }

        public String? TpCobertura { get; set; }

    }
}
