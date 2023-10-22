using HealthCare.Web.AspNet.Models;
using Oracle.ManagedDataAccess.Client;

namespace HealthCare.Web.AspNet.Repository
{
    public class ExameRepository
    {

        private string? connectionString;
        private OracleConnection? connection;

        public ExameRepository()
        {
            connectionString = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build().GetConnectionString("DatabaseConnectio");

            connection = new OracleConnection(connectionString);
        }

        public IList<ExameModel> Listar(ExameModel exame)
        {
            var lista = new List<ExameModel>();
            using (connection)
            {
                var query = "SELECT IDEXAME, NMEXAME, VLRESULTADO, DTEXAME";


                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ExameModel consulta = new ExameModel();
                   
                    exame.IdExame = Convert.ToString(dataReader["IDEXAME"]);
                    exame.NmExame = Convert.ToString(dataReader["NMEXAME"]);
                    exame.VlResultado = Convert.ToString(dataReader["VLRESULTADO"]);
                    exame.DtExame = Convert.ToString(dataReader["DTEXAME"]);

                    lista.Add((ExameModel)exame);
                }

                connection.Close();
            }
            return lista;

        }

        public ExameModel Consultar(string id)
        {
            var exame = new ExameModel();
            using (connection)
            {
                var query = "SELECT IDEXAME, NMEXAME, VLRESULTADO, DTEXAME";

                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add("ID", id);

                OracleDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    exame.IdExame = Convert.ToString(dataReader["IDEXAME"]);
                    exame.NmExame = Convert.ToString(dataReader["NMEXAME"]);
                    exame.VlResultado = Convert.ToString(dataReader["VLRESULTADO"]);
                    exame.DtExame = Convert.ToString(dataReader["DTEXAME"]);
                }

                connection.Close();

            }

            return exame;
        }

        public void Inserir(ExameModel exame)
        {
            using (connection)
            {
                String query = "INSERT INTO EXAME (DTEXAME, VLRESULTADO";

                connection.Open();


                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add("data", exame.DtExame);
                command.Parameters.Add("VALOR", exame.VlResultado);

                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void Excluir(String id)
        {
            using (connection)
            {
                String query = "DELETE EXAME WHERE IDEXAME = :id";

                connection.Open();


                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add("id", id);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
