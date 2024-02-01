using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormaPagamentoDAL
    {
        public void Inserir(FormaPagamento _pagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO FormaPagamento(Tipo, Descricao, Troco) 
                                    VALUES(@Tipo, @Descricao, @Troco)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Tipo", _pagamento.Tipo);
                cmd.Parameters.AddWithValue("@Descricao", _pagamento.Descricao);
                cmd.Parameters.AddWithValue("@Troco", _pagamento.Troco);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma forma de pagamento no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(FormaPagamento _pagamento)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE FormaPagamento SET Tipo = @Tipo,
                                                          Descricao = @Descricao,
                                                          Troco = @Troco
                                                          WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _pagamento.Id);
                cmd.Parameters.AddWithValue("@Nome", _pagamento.Tipo);
                cmd.Parameters.AddWithValue("@Nome", _pagamento.Descricao);
                cmd.Parameters.AddWithValue("@Nome", _pagamento.Troco);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Forma de Pagamento no banco de dados", ex) { Data = { { "Id", 10071 } } };
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
                cmd.CommandText = @"DELETE FROM FormaPagamento WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Forma de pagamento no banco de dados.", ex) { Data = { { "Id", 10072 } } };
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
