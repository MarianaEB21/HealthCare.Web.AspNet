namespace HealthCare.Web.AspNet.Models
{
    public class ExameModel
    {
        public ExameModel() { }

        public ExameModel(string idExame, string? NmExame, string? VlResultado, string? DtExame)
        {
            this.IdExame = idExame;
            this.NmExame = NmExame;
            this.VlResultado = VlResultado;
            this.DtExame = DtExame;
        }
        public string IdExame { get; set; }
        public string? NmExame { get; set; }
        public string? VlResultado { get; set; }
        public string? DtExame { get; set; }

    }
}
