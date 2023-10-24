namespace HealthCare.Web.AspNet.Models
{
    public class UsuarioModel
    {
        public UsuarioModel() { }

        public UsuarioModel(string idCpf, string? nmUsuario, DateOnly? dtNascimento, string? endereco, string? cidade, string? numContato, string? tpSanguineo, string? genero)
        {
            IdCpf = idCpf;
            NmUsuario = nmUsuario;
            DtNascimento = dtNascimento;
            Endereco = endereco;
            Cidade = cidade;
            NumContato = numContato;
            TpSanguineo = tpSanguineo;
            Genero = genero;
        }
        public string IdCpf { get; set; }
        public string? NmUsuario { get; set; }
        public DateOnly? DtNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? NumContato { get; set; }
        public string? TpSanguineo { get; set; }
        public string? Genero { get; set; }

        
    }
}
