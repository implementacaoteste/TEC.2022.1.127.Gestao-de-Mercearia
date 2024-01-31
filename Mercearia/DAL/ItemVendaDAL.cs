using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemVendaDAL
    {
        public void Inserir(ItemVenda _item)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ItemVenda(IdProduto, IdVenda, Quantidade, ValorUnitario, SubTotal) 
                                    VALUES(@IdProduto, @IdVenda, @Quantidade, @ValorUnitario, @SubTotal)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdProduto", _item.IdProduto);
                cmd.Parameters.AddWithValue("@IdVenda", _item.IdVenda);
                cmd.Parameters.AddWithValue("@Quantidade", _item.Quantidade);
                cmd.Parameters.AddWithValue("@ValorUnitario", _item.ValorUnitario);
                cmd.Parameters.AddWithValue("@SubTotal", _item.SubTotal);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um item no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
