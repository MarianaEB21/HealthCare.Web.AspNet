namespace HealthCare.Web.AspNet.Models
{
    public class MedicoModel
    {

        public int IdCrm { get; set; }

        public String? NmMedico { get; set; }

        public String? TpEspecialidade { get; set; }

        public String? LocalAtendimento { get; set; }

        public String? NumContato { get; set; }

        public MedicoModel(int idCrm, string nmMedico)
        {
            IdCrm = idCrm;
            NmMedico = nmMedico;

        }
    }
}


