namespace HealthCare.Web.AspNet.Models
{
    public class UsuarioModel
    {

        public String? CdCpf { get; set; }

        public String? NomeUsuario { get; set; }

        public DateOnly? DtNascimento { get; set; }

        public String? EndLogradouro { get; set; }

        public String? EndCidade { get; set; }

        public String? NumContato { get; set; }

        public String? TpSanguineo { get; set; }

        public String? Genero { get; set; }

        public UsuarioModel()
        {

        }
    }
}
