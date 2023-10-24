using HealthCare.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.Web.AspNet.Repository.Context
{
    public class DataBaseContext : DbContext

    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        protected DataBaseContext()
        {
        }

        //Propriedade que será responsável pelo acesso às tabelas
        public DbSet<ConsultaModel> Consulta { get; set; }
        public DbSet<MedicoModel> Medico { get; set; }
        public DbSet<PlanoSaudeModel> PlanoSaude { get; set;}
        public DbSet<ExameModel> Exame { get; set; }

    }
}
