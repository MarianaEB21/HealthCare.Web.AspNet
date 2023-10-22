namespace HealthCare.Web.AspNet.Models
{
    public class ExameModel
    {
        public ExameModel()
        {
        }

        public ExameModel(String idExame, String NmExame, String VlResultado, String DtExame)
        {
            this.IdExame = idExame;
            this.NmExame = NmExame;
            this.VlResultado = VlResultado;
            this.DtExame = DtExame;
        }

        public String? IdExame { get; set; }

        public String? NmExame { get; set; }

        public String? VlResultado { get; set; }

        public String? DtExame { get; set; }



    }
}
