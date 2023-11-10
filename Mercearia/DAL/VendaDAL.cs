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
    }
}
