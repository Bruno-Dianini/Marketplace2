using System;
using System.Data.SqlClient;

namespace AppEmpresa
{
    public class ConnectionFactory
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "SuaStringDeConexao"; // Substitua pela sua string de conexão
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Conectado!");
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Falha na conexão: " + ex.Message);
                return null;
            }
        }
    }
}
