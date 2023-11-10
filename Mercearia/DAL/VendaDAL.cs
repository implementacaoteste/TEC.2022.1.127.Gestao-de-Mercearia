using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendaDAL
    {
        public void Inserir(Venda _venda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Venda(Id, IdFuncionario, IdCliente, IdProduto, PrecoVenda, IdFormaPagamento, DataVenda)VALUES(@Id, @IdFuncionario, @IdCliente, @IdProduto, @PrecoVenda, @IdFormaPagamento, @DataVenda)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _venda.Id);
                cmd.Parameters.AddWithValue("@IdFuncionario", _venda.IdFuncionario);
                cmd.Parameters.AddWithValue("@IdCliente", _venda.IdCliente);
                cmd.Parameters.AddWithValue("@IdProduto", _venda.IdProduto);
                cmd.Parameters.AddWithValue("@PrecoVenda", _venda.PrecoVenda);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", _venda.IdFormaPagamento);
                cmd.Parameters.AddWithValue("@DataVenda", _venda.DataVenda);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw new Exception("Ocorre um erro ao inserir uma venda no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Venda _venda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Venda SET IdFuncionario = @IdFuncionario, IdCliente = @IdCliente, IdProduto = @IdProduto, PrecoVenda = @PrecoVenda, IdFormaPagamento = @IdFormaPagamento, DataVenda = @DataVenda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _venda.Id);
                cmd.Parameters.AddWithValue("@IdFuncionario", _venda.IdFuncionario);
                cmd.Parameters.AddWithValue("@IdCliente", _venda.IdCliente);
                cmd.Parameters.AddWithValue("@IdProduto", _venda.IdProduto);
                cmd.Parameters.AddWithValue("@PrecoVenda", _venda.PrecoVenda);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", _venda.IdFormaPagamento);
                cmd.Parameters.AddWithValue("@DataVenda", _venda.DataVenda);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma venda no banco de dados.", ex);
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
                cmd.CommandText = @"DELETE FROM Venda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma venda no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
