using System;
using System.Data;
using System.Data.SqlClient;

namespace AtividadeLogin.Banco
{
    public class Context
    {
        private string ConnectionString = "Data Source=DESKTOP-R9JFMSC\\SQLEXPRESS; Initial Catalog=AdoNet;User ID=usuario; password=senha";
        private SqlConnection cn;

        private void Conexao()
        {
            cn = new SqlConnection(ConnectionString);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable ExecutarConsultaGenerica(string sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new(command);

                DataTable dt = new();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
