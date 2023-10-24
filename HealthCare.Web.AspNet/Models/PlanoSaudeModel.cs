namespace HealthCare.Web.AspNet.Models
{
    public class PlanoSaudeModel
    {
        public PlanoSaudeModel() { }

        public PlanoSaudeModel(string idPlano, string? tpPlano, string? nmPlano, string? tpCobertura)
        {
            this.IdPlano = idPlano;
            this.TpPlano = tpPlano;
            this.NmPlano = nmPlano;
            this.TpCobertura = tpCobertura;
        }
        public string IdPlano { get; set; }
        public string? TpPlano { get; set; }
        public string? NmPlano { get; set; }
        public string? TpCobertura { get; set; }

    }
}
