using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SenhaDAL
    {
        public void Inserir(Senha _senha)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Senha(Id, IdCliente)VALUES(@Id, @IdCliente)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _senha.Id);
                cmd.Parameters.AddWithValue("@IdCliente", _senha.IdCliente);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma senha no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Senha> BuscarTodos()
        {
            List<Senha> senhas = new List<Senha>();
            Senha senha = new Senha();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT Id, IdCliente FROM Senha GROUP BY IdCliente ORDER BY Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        senha = new Senha();
                        senha.Id = (int)rd["Id"];
                        senha.IdCliente = (int)rd["IdCliente"];
                        senhas.Add(senha);
                    }
                }
                return senhas;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar as senhas no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Senha WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a senha do banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
