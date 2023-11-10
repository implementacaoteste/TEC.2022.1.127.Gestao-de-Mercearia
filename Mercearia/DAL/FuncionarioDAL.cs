using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL
    {
        public void Inserir(Funcionario _funcionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Funcionario(Nome, Fone, Ativo, Profissao, Salario) 
                                    VALUES(@Nome, @Fone, @Ativo, @Profissao, @Salario)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@Fone", _funcionario.Fone);
                cmd.Parameters.AddWithValue("@Ativo", _funcionario.Ativo);
                cmd.Parameters.AddWithValue("@Profissao", _funcionario.Profissao);
                cmd.Parameters.AddWithValue("@Salario", _funcionario.Salario);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um funcionario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }



    }
}
