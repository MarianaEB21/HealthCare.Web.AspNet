namespace HealthCare.Web.AspNet.Models
{
    public class MedicoModel
    {
        public MedicoModel() { }

        public MedicoModel(string idCrm, string nmMedico, string tpEspecialidade, string lcAtendimento, string numContato)
        {
            IdCrm = idCrm;
            NmMedico = nmMedico;
            TpEspecialidade = tpEspecialidade;
            LcAtendimento = lcAtendimento;
            NumContato = numContato;
        }
        public string IdCrm { get; set; }
        public string? NmMedico { get; set; }
        public string? TpEspecialidade { get; set; }
        public string? LcAtendimento { get; set; }
        public string? NumContato { get; set; }

    }
}


