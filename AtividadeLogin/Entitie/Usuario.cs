using AtividadeLogin.Banco;
using AulaCriptografia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLogin.Entitie
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string senha, string chave)
        {
            CriptoSimetrica sim = new();
            Nome = nome;
            Email = email;
            Senha = sim.EncryptData(senha, chave);
        }

        public Usuario(string nome, string email, string senha)
        {
            CriptoAssimetrica assim = new();
            Nome = nome;
            Email = email;
            Senha = assim.encrypt(senha);
        }

        public Usuario(){}

        public bool GravarUsuario()
        {
            Context bd = new();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = $"insert into Usuario values(@Nome, @Email, @Senha)";
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters.Add("@Senha", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Email;
            command.Parameters[2].Value = Senha;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public Usuario ConsultaUsuario(string email)
        {
            Context bd = new();
            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new($"select * from Usuario where Email like '{email}'", cn);

                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString(2) == email)
                    {
                        Id = rdr.GetInt32(0);
                        Nome = rdr.GetString(1);
                        Email = rdr.GetString(2);
                        Senha = rdr.GetString(3);
                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
