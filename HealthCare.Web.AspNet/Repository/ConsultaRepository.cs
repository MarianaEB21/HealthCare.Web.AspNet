using HealthCare.Web.AspNet.Models;
using Oracle.ManagedDataAccess.Client;

namespace HealthCare.Web.AspNet.Repository
{
    public class ConsultaRepository
    {

        private string? connectionString;
        private OracleConnection? connection;

        public ConsultaRepository()
        {
            connectionString = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build().GetConnectionString("DatabaseConnection");

            connection = new OracleConnection(connectionString);
        }

        public IList<ConsultaModel> Listar()
        {
            var lista = new List<ConsultaModel>();
            using (connection)
            {
                var query = "SELECT DH_CONSULTA, ID FROM TBL_CONSULTA";

                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ConsultaModel consulta = new ConsultaModel();
                    consulta.IdConsulta = Convert.ToString(dataReader["IDCONSULTA"]);
                    consulta.DtConsulta = Convert.ToString(dataReader["DTCONSULTA"]);
                    consulta.TpConsulta = Convert.ToString(dataReader["TPCONSULTA"]);

                    lista.Add(consulta);
                }

                connection.Close();
            }
            return lista;

        }

        public ConsultaModel Consultar(string id)
        {
            var consulta = new ConsultaModel();
            using (connection)
            {
                var query = "SELECT IDCONSULTA, DTCONSULTA, TPCONSULTA";

                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add("ID", id);

                OracleDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    consulta.IdConsulta = Convert.ToString(dataReader["IDCONSULTA"]);
                    consulta.DtConsulta = Convert.ToString(dataReader["DTCONSULTA"]);
                    consulta.TpConsulta = Convert.ToString(dataReader["TPCONSULTA"]);
                }

                connection.Close();

            }

            return consulta;
        }
        
        public void Inserir(ConsultaModel consulta)
        {
            using (connection)
            {
                String query = "INSERT INTO CONSULTA (DTCONSULTA, TPCONSULTA";

                connection.Open();
                
                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add("data", consulta.DtConsulta);
                command.Parameters.Add("tipo", consulta.TpConsulta);

                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void Excluir(String id)
        {
            using (connection)
            {
                String query = "DELETE CONSULTA WHERE IDCONSULTA = :id";

                connection.Open();


                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add("id", id);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
