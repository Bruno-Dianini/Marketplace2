using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AppEmpresa
{
    public class ClienteDao
    {
        private SqlConnection connection;

        public ClienteDao()
        {
            string connectionString = "SuaStringDeConexao"; // Substitua pela sua string de conexão
            this.connection = new SqlConnection(connectionString);
        }

        public void Adiciona(Cliente cliente)
        {
            string sql = "INSERT INTO cliente (nome, endereco, telefone, rg, email, cpf) VALUES (@Nome, @Endereco, @Telefone, @Rg, @Email, @Cpf)";
            try
            {
                this.connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, this.connection))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Rg", cliente.Rg);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public List<Cliente> GetLista()
        {
            string sql = "SELECT * FROM cliente";
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                this.connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, this.connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.Nome = reader["nome"].ToString();
                            cliente.Endereco = reader["endereco"].ToString();
                            cliente.Telefone = reader["telefone"].ToString();
                            cliente.Rg = reader["rg"].ToString();
                            cliente.Email = reader["email"].ToString();
                            cliente.Cpf = reader["cpf"].ToString();

                            clientes.Add(cliente);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return clientes;
        }
    }
}
